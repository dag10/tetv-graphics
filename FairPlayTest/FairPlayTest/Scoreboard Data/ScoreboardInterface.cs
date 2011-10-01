using System;
using System.IO.Ports;
using System.Text;

namespace Scoreboard_Communication {
    class ScoreboardInterface {
        private volatile bool shouldStop = false;
        private bool connected = false;
        private string serialPortName = "";
        private SerialPort serialPort = null;

        private Game_Clock_Record gameClockRecord = null;
        private Football_Record footballRecord = null;
        private Soccer_Record soccerRecord = null;

        public SerialConnectionStatusChanged StatusChanged;
        public PassException DisplayException;
        public GameClockRecordUpdated GameClockUpdated;
        public FootballRecordUpdated FootballUpdated;
        public SoccerRecordUpdated SoccerUpdated;

        #region Thread Management

        public void StartThread() {
            // Map delegates
            StatusChanged += this.LocalStatusChanged;

            // Initialize serialPort
            serialPort = new SerialPort();
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.Parity = Parity.None;

            // Enter main loop
            while (!shouldStop) {
                Tick();
            }

            // Clean up
            if (connected)
                StopSerialConnection();
        }

        public void StopThread() {
            shouldStop = true;
            StopSerialConnection();
        }

        #endregion

        #region Connection Management

        public void StartSerialConnection(string portName) {
            try {
                if (serialPort.IsOpen)
                    serialPort.Close();
            } catch (Exception e) {
                DisplayException(e);
            }

            if (portName == null) return;
            serialPortName = portName;

            gameClockRecord = new Game_Clock_Record();
            footballRecord = new Football_Record();
            soccerRecord = new Soccer_Record();

            serialPort.PortName = serialPortName;
            try {
                serialPort.Open();
            } catch (Exception e) {
                DisplayException(e);
            }

            StatusChanged(serialPort.IsOpen);
        }

        public void StopSerialConnection() {
            try {
                if (serialPort.IsOpen)
                    serialPort.Close();
            } catch (Exception e) {
                DisplayException(e);
            }

            StatusChanged(serialPort.IsOpen);
        }

        #endregion

        #region Scoreboard Communication

        private void Tick() {
            if (connected) {
                // Check for disconnection
                if (!serialPort.IsOpen)
                    StatusChanged(false);

                // Read data
                try {
                    if (serialPort.ReadByte() == 0x02) {    // Start of TX
                        char recordType = (char)serialPort.ReadChar();
                        //Console.WriteLine("Record Type: " + Char.ToString(recordType));
                        switch (recordType) {
                            case 'C': {
                                    char[] buffer = new char[Game_Clock_Record.size];
                                    while (serialPort.BytesToRead < buffer.Length) ;
                                    serialPort.Read(buffer, 0, buffer.Length);
                                    if (gameClockRecord.Update(buffer))
                                        GameClockUpdated(gameClockRecord);
                                    break;
                                }
                            case 'F': {
                                    char[] buffer = new char[Football_Record.size];
                                    while (serialPort.BytesToRead < buffer.Length) ;
                                    serialPort.Read(buffer, 0, buffer.Length);
                                    if (footballRecord.Update(buffer))
                                        FootballUpdated(footballRecord);
                                    break;
                                }
                            case 'R': {
                                    char[] buffer = new char[Soccer_Record.size];
                                    while (serialPort.BytesToRead < buffer.Length) ;
                                    serialPort.Read(buffer, 0, buffer.Length);
                                    if (soccerRecord.Update(buffer))
                                        SoccerUpdated(soccerRecord);
                                    break;
                                }
                            default:
                                Console.WriteLine("Unknown Record Type: " + Char.ToString(recordType));
                                break;
                        }
                    }
                } catch (Exception e) {
                    // Nothing
                }
            }
        }

        #endregion

        #region Local Delegates

        private void LocalStatusChanged(bool status) {
            this.connected = status;
        }

        #endregion
    }
}
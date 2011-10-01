// Serial status
public delegate void StartSerialConnection(string portName);
public delegate void StopSerialConnection();
public delegate void SerialConnectionStatusChanged(bool status);

// Exceptions
public delegate void PassException(System.Exception exception);

// Record updates
public delegate void GameClockRecordUpdated(Scoreboard_Communication.Game_Clock_Record record);
public delegate void FootballRecordUpdated(Scoreboard_Communication.Football_Record record);
public delegate void SoccerRecordUpdated(Scoreboard_Communication.Soccer_Record record);
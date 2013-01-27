
#include <QtGui/QApplication.h>
#include <QtGui/QPushButton.h>
#include <QtGui/QLabel.h>
#include <QtGui/QBoxLayout.h>

int main(int argc, char *argv[])
{
	QApplication a(argc, argv);
	QWidget window;
	
	QVBoxLayout layout(&window);

	// Tease message
	QLabel lblTease("(insert graphics program here)");
	layout.addWidget(&lblTease, 1);

	layout.addSpacing(20);

	// Close button
	QPushButton btnClose("Close me");
	QWidget::connect(&btnClose, SIGNAL(clicked()), &window, SLOT(close()));
	layout.addWidget(&btnClose, 0);

	window.setMinimumSize(230, 80);
	window.setWindowTitle("TETV Graphics");
	window.show();
	return a.exec();
}

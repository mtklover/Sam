# bellatrix

! THIS IS A CURRENT WORK IN PROGRESS !

### Samsung mobile device identification/functions using the Hayes command set, also known as the AT (Attention) command set.

ADB (USB Debugging) is not required for bellatrix, but some commands may not work if the screen is locked

*MORE INFORMATION COMING SOON*

### Included in default **"Commands.xml"** file

- Device Identification (AT+DEVCONINFO)
	- IMEI
	- Serial Number
	- Model Number
	- Carrier
	- Activation Lock (AT+REACTIVE=1,0,0)
	- Storage Size (AT+SIZECHECK=?)
	- Network Lock (AT+SVCIFPGM=1,4)
	- Android Version (AT+VERSNAME=3,2,3)

- Download Mode (AT+SUDDLMOD=0,0)

- Factory Reset (AT+FACTORST=0,0)

*MORE COMING SOON*

### Included in default **"Scripts.xml"** file

*COMING SOON*

# bellatrix

! THIS IS A CURRENT WORK IN PROGRESS !

Windows Form (.Net 6)

### Samsung mobile device identification/functions using the Hayes command set, also known as the AT (Attention) command set.

[WIP SCREENSHOT](bellatrixteaser.PNG "WIP SCREENSHOT")

ADB (USB Debugging) is not required for bellatrix, but some commands may not work if the screen is locked

*MORE INFORMATION & SCREENSHOTS COMING SOON*

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

- Touch Screen Emulation
	- Single Tap (AT+CTSA=2,500,500)
	- Double Tap (AT+CTSA=3,500,500)
	- Swipe (AT+CTSA=1,500,500;+CTSA=0,1000,1000)

*MORE COMING SOON*

### Included in default **"Scripts.xml"** file

- Pull Information (Pulls all information from included commands)

- Enable USB Debugging (Enables USB Debugging) *COMING SOON* ;)

*MORE COMING SOON*

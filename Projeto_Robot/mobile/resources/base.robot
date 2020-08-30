***Settings***
Documentation       Codigo para abrir uma sessao com o appium server

Library         AppiumLibrary


Resource        kws.robot



***Keywords***
# Hooks

Open Session
    Open application        http://localhost:4723/wd/hub
    ...                     automationName=UiAutomator2
    ...                     platformName=Android
    ...                     deviceName=Android Emulator
    ...                     app=${EXECDIR}/app/ninjachef.apk
    ...                     udid=emulator-5554
    ...                     adbExecTimeout=120000

Close Session
    Capture Page Screenshot
     Close application

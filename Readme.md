# Code Consultants Startup Hook(s)

#### Background

You can use startup hooks to inject code into any .net application

See https://bartwullems.blogspot.com/2022/03/impress-your-colleagues-with-your.html

#### About

The `CodeConsultantsWelcomeStartupHook` project creates a simple startup hook that adds a copyright console message.

#### Usage

In general these hooks are used via the `DOTNET_STARTUP_HOOKS` environment variable e.g.
```
SET DOTNET_STARTUP_HOOKS=c:\....\Hook1.dll;c:\....\Hook2.dll"
```

Assuming use of saving repo to `c:\Development\StartupHooks\` then the helper scripts are available
	(otherwise copy/tweak to suite your environment).

* Use `set-debug-hook.bat` to assign the CodeConsultantsWelcomeStartupHook Debug dll
* Use `set-release-hook.bat` to assign the CodeConsultantsWelcomeStartupHook Release dll
* Use `run.bat` to execute the `ConsoleApp` project

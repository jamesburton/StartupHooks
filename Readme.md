# Code Consultants Startup Hook(s)

#### Background

You can use startup hooks to inject code into any .net application

See https://bartwullems.blogspot.com/2022/03/impress-your-colleagues-with-your.html

#### About

* The `CodeConsultantsWelcomeStartupHook` project creates a simple startup hook that adds a copyright console message.
* The `InvertedConsole` project creates a wrapper to invert console output.

#### Usage

In general these hooks are used via the `DOTNET_STARTUP_HOOKS` environment variable e.g.
```
SET DOTNET_STARTUP_HOOKS=c:\....\Hook1.dll;c:\....\Hook2.dll"
```

Assuming use of saving repo to `c:\Development\StartupHooks\` then the helper scripts are available
	(otherwise copy/tweak to suite your environment).

* Using `CodeConsultantsWelcomeStartupHook`:
	* Use `set-debug-hook.bat` to assign the CodeConsultantsWelcomeStartupHook Debug dll
	* Use `set-release-hook.bat` to assign the CodeConsultantsWelcomeStartupHook Release dll
* Using `InvertedConsole`:
	* Use `inverted-debug.bat` to assign the CodeConsultantsWelcomeStartupHook Debug dll
	* Use `inverted-release.bat` to assign the CodeConsultantsWelcomeStartupHook Release dll
* Use `clear-hooks.bat` to assign the CodeConsultantsWelcomeStartupHook Release dll
* Use `run.bat` to execute the `ConsoleApp` project

#### References

* Design Notes: https://github.com/dotnet/runtime/blob/main/docs/design/features/host-startup-hook.md
* Fun with Startup Hooks: https://medium.com/criteo-engineering/c-have-some-fun-with-net-core-startup-hooks-498b9ad001e1
# What is this thing? #

SIF-less is a UI Wrapper for Sitecore Installation Framework (SIF).  For those who don't want to mess with parameters and commandline, this is for you.

## Version 0.3.0 ##

* NEW VERSION!
* SIF-less now forces you to run in Admin mode.  You need to do this with SIF anyway, so....why not?
* Uninstall is here!  You'll notice that when you Generate the install file "SIFless-EZ-1508971675.ps" you'll now get a "SIFless-EZUninstall-1508971675.ps1" as well. Simply run that from powershell and you're good.
* You must place the Contents of the Scripts folder in the same location as your JSON configuration files.  
* This Uninstall Script is 100% SIF-based for easy expanding.
* The alert on completion now shows a duration that the install ran.

## Version 0.2.2 ##
A new "EZ Mode" has been added. It's the default tab when you load. It looks/feels a lot like the SIM tool.  You populate the appropriate fields
SIF-less is a UI Wrapper for Sitecore Installation Framework (SIF).  For those who don't want to mess with parameters and commandline, this is for you.

If you want to generate a file only, and run it again, just ensure the "Generate File Only " checkbox is checked.  Regardless of this box, a file will be dropped in the location you run SIF-less.

### How do you use it? ###

* Run SIF-less.exe
* Click "Select a File" to pick a SIF Config File
* Fill in all the fields.  Skipping a field will prevent you from running the script.  Note: Defaults specified in the config are loaded for you.
* Watch the scrolling text and relax

### What should I know? ###
* Run SIF-less in Admin Mode.  You'd do it with powershell, right?
* SIF-less does not prefer 32bit.  It will run, but ensure you have all the IIS SnapIns in place, or you'll see COM issues.
* SIF is required for SIF-less to run.  It's called SIF-less, not SIF-free.

### Who do I talk to? ###

* Rob. I'm the owner.  Please feel free to report bugs, fork your own, etc.  Hit me up on Sitecore Community Slack @rob.ahnemann

### License? ###

Copyright (c) 2017 Rob Ahnemann

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

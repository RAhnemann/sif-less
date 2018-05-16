# What is this thing? #

SIF-less 2 is a UI Wrapper for Sitecore Installation Framework (SIF).  It's not called "SIF-non", as it still requires SIF to operate.  For those who don't want to mess with parameters and the command line, this is for you.

## Version 2.0.0.0 - Beta 1 ##

* Rewrote almost the whole damn thing.
* Rather than all fields in one place, created a system of profiles.  Mix and match profiles to suit your needs!
* Profile data saved to disk for portability.  
* All Validators are dynamic now, and fully extensible.
* Output from the generation of scripts is fully flexible, modular and ripe for extensibility.
* One output file is generated. It contains both the install and uninstall. Trigger the uninstall by passing a "-uninstall" switch to the EZ file.

## Where can I read more? ##
Hit up http://rockpapersitecore.com for more info.


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

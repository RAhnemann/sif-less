# What is this thing? #

SIF-less 2 is a UI Wrapper for Sitecore Installation Framework (SIF).  It's not called "SIF-non", as it still requires SIF to operate.  For those who don't want to mess with parameters and the command line, this is for you.


## Version 2.0.3.0 - Beta 1 Update 3 ##

* Added a Secure Password to the configs.  This is used in all non-admin connections in order to ensure installation is not halted by using passwords that don't adhere to the local password plolicy
* Added in support for Habitat Topologies.  This is only available for Sitecore 9.0 Update 2 and can be found in the Topology list when selecting Version 9.0 Update 2.
* Fixed issues with the File Selector and added in a Folder Selector Control.
* Fixed an issue where not having a default value caused an error when updating a custom field.
* Added a timer so you can see an overall execution time for the entire script.
* 

## Version 2.0.2.0 - Beta 1 Update 2 ##

* Completely revamped the uninstall process. Rather than using SIF for uninstall, we're going with plain PowerShell.  This might not be the end-game here, but this is a lot cleaner and fault tolerant.  It can also be re-run multiple times to clean up an instance, and it won't fail.
* Added checks in the generated PS1 file for SIF install, SitecoreFundamentals, Admin mode and PowerShell version.
* Simplified the Configuration Manifest file.  Moved fields to a configuration, rather than a file.  Files now shouldn't contain Script Maps, as those really just belong at the Version/Topology Combo level.
* On the Main Window, all the Configurations should sort alphabetically.
* Name the topologies something more meaningful: XM0, XM1, and XP0. (Note: If you have existing configurations saved, you may need to re-save them.  It shouldn't drop them from SIF-less..if it does, let me know in the comments)

## Version 2.0.1.0 - Beta 1 Update 1 ##

* No longer crashes when selecting certain topologies
* Fixed an error when replacing bookmarks in the EZ ps1 files
* Changed Versions and Typologies to be dynamic based on configurations available. This will allow the addition of new versions/configs with a single file change (for now)
* Addition of Dynamic Field values and defaults.  Much like SIF-less 1, when you change the prefix, it updates the corresponding field values for it.  This is stored in the form of a bookmark in the ConfigurationManfest file in a defaultValue attribute.
* Added in Sitecore 9.0 Update 2 for the configurations

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

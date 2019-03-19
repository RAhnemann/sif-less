# What is this thing? #

SIF-less 2 is a UI Wrapper for Sitecore Installation Framework (SIF).  It's not called "SIF-non", as it still requires SIF to operate.  For those who don't want to mess with parameters and the command line, this is for you.

## Version 2.2.0 ##

* SIF-less now has a way to run the generated PS1 files for you, rather than having to launch PowerShell and running it manually.  A couple neat features here:
	* The SIFless-EZ file is still written to disk, so you're able to run it by hand if you want to. Yay for legacy!
	* The UI that launches determines runtime switches of the PS1.  It uses some fancy technology called 'Regular Expressions' to sniff these out. See also: Satan.  Simply check the box to pass the parameter into the file.
	* Output is timestamped when written to the UI textboxes
	* Output is segmented by level. There are different tabs for each type: Error, Verbose, Information, and Warning.  There's also a 'All' window.
	* Progress bars and status bars work to let you know how things are progressing.  I guess that's why they're called 'Progress Bars'
	* EXPERIMENTAL: You can run external SIF-EZ script files through this feature.  Click on the 'Run External Script' button to launch a file browser. Use at your own risk though.  
* SIF-less now allows for the automatic downloading of SIF-less configuration files.  You can check the validity of your files by clicking the 'Update' Menu. This window essentially downloads a manifest file, checks some hashes and lets you know what needs to change.
	* You're gonna need an internet connection to do this.  Also access to GitHub.
	* You can disable this feature at startup by clicking the 'Settings' Menu and unchecking the box.  This should persist across sessions.
	* By default this feature is enabled.
	* This is going to make getting updated configs (Future Sitecore releases) super easy, and require no application downloads.  Yay!

## Version 2.1.2 ##

* Saving your SIFless-EZ file will now try to make you save it as '.ps1' because well... that's who he is.
* The SIFless-EZ files will now try to do some validation ahead of the install.  Great for catching things that changed since the script was generated.
	* Is Solr running?
	* Is Solr the right version? (6.6.2 and 6.6.3 for 9.0.x and 7.2.1 for 9.1.x)
	* Is the file path to solr correct?
	* Are there the appropriate configsets present in solr?
	* Is the license file present? (Not your MVP license...)
	* Is SQL running?
	* Is SQL the right version (2016 SP1 for 9.0.x and 2016 SP2 or 2017 for 9.1.x)
	* Can the user log in?
	* Can the user actually create DBs?
* Added some switches to pass into the SIFless-EZ file
	* -ValidateOnly - Performs Validation of the environment, no install happens
	* -SkipValidation - Does exactly what you expect it to...
	* -IgnoreSQL2016SP2 - You probably have SQL 2016 SP2 running on your local.  9.0.x "officially" supports SP1 only. This ignores that check because nobody is going to run SP1 and SP2 side by side.  Silly. (This is for 9.0.x installs only)
	* -Uninstall - I dunno that I need to explain this... ok, I give up. It uninstalls. 

## Version 2.1.1 ##

* XP0 installs will now be forced to run in HTTPs.
* The Password Recovery Url should now be HTTPS by default.
* The role for a XM0 server should now be "StandAlone", rather than "ContentManagement"
* When editing a Sitecore profile, SIF-less won't default to XM0 anymore.
* SIF-less will only try to uninstall SIF (to ensure the right version) if it's loaded.
* I changed "SkipPreReqCheck" to "ForcePreReqCheck" so by default, you don't try to keep installing stuff over and over....and over...
* Removed the Scripts folder from the solution, as we're pure PowerShell for uninstalls

## Version 2.1.0 ##

* Support for Sitecore 9.1 Initial Release (XM0, XM1, XP0)
* Fixed an error preventing the deletion of solr configs
* Support for Solr 7.2.1+
* Manifest files are now stored in a folder, allowing for custom manifests and templates
* Minor UI enhancements.  Still is ugly.
* Sitecore 9.1: Forced the default password for Sitecore Admin to "b".  Change it if you want, it won't hurt my feelings.
* Removed the #Requires from the install templates.  This caused some nasty issues trying to install SC9.0 and 9.1 side by side

## Version 2.0.3 - Beta 1 Update 3 ##

* Split configuration scripts into a single file per version, to allow for more flexibility.
* Added in support for Habitat Topologies.  This is only available for Sitecore 9.0 Update 2 and can be found in the Topology list when selecting Version 9.0 Update 2.
* Fixed issues with the File Selector and added in a Folder Selector Control.
* Fixed an issue where not having a default value caused an error when updating a custom field.
* Added a timer so you can see an overall execution time for the entire script.

## Version 2.0.3 - Beta 1 Update 3 ##

* Added a Secure Password to the configs.  This is used in all non-admin connections in order to ensure installation is not halted by using passwords that don't adhere to the local password policy
* Added in support for Habitat Topologies.  This is only available for Sitecore 9.0 Update 2 and can be found in the Topology list when selecting Version 9.0 Update 2.
* Fixed issues with the File Selector and added in a Folder Selector Control.
* Fixed an issue where not having a default value caused an error when updating a custom field.
* Added a timer so you can see an overall execution time for the entire script.
* 

## Version 2.0.2 - Beta 1 Update 2 ##

* Completely revamped the uninstall process. Rather than using SIF for uninstall, we're going with plain PowerShell.  This might not be the end-game here, but this is a lot cleaner and fault tolerant.  It can also be re-run multiple times to clean up an instance, and it won't fail.
* Added checks in the generated PS1 file for SIF install, SitecoreFundamentals, Admin mode and PowerShell version.
* Simplified the Configuration Manifest file.  Moved fields to a configuration, rather than a file.  Files now shouldn't contain Script Maps, as those really just belong at the Version/Topology Combo level.
* On the Main Window, all the Configurations should sort alphabetically.
* Name the topologies something more meaningful: XM0, XM1, and XP0. (Note: If you have existing configurations saved, you may need to re-save them.  It shouldn't drop them from SIF-less..if it does, let me know in the comments)

## Version 2.0.1 - Beta 1 Update 1 ##

* No longer crashes when selecting certain topologies
* Fixed an error when replacing bookmarks in the EZ ps1 files
* Changed Versions and Typologies to be dynamic based on configurations available. This will allow the addition of new versions/configs with a single file change (for now)
* Addition of Dynamic Field values and defaults.  Much like SIF-less 1, when you change the prefix, it updates the corresponding field values for it.  This is stored in the form of a bookmark in the ConfigurationManfest file in a defaultValue attribute.
* Added in Sitecore 9.0 Update 2 for the configurations

## Version 2.0.0 - Beta 1 ##

* Rewrote almost the whole damn thing.
* Rather than all fields in one place, created a system of profiles.  Mix and match profiles to suit your needs!
* Profile data saved to disk for portability.  
* All Validators are dynamic now, and fully extensible.
* Output from the generation of scripts is fully flexible, modular and ripe for extensibility.
* One output file is generated. It contains both the install and uninstall. Trigger the uninstall by passing a "-uninstall" switch to the EZ file.

## Where can I read more? ##
Hit up http://rockpapersitecore.com for more info.


### License? ###

Copyright (c) 2017-2019 Rob Ahnemann

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

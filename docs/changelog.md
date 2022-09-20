---
permalink: /Changelog.html
title: The Change Log
description: The Opening Credits, and the closing credits, plus the first of two (or is three) end credit scenes
tags: changes,changelog,change-log,page,kerbal,ksp,zer0Kerbal,zedK
---

<!-- 
hdr-changelog.md v1.0.0.0
ScrapYard! (SYD)
created: 13 May 2022
updated:
CC BY-ND 4.0 by zer0Kerbal
--># Changelog  
  
| modName    | ScrapYard (SYD)                                                  |
| ---------- | ---------------------------------------------------------------- |
| license    | Expat/MIT                                                        |
| author     | magico13, severedsolo and zer0Kerbal                             |
| forum      | (https://forum.kerbalspaceprogram.com/index.php?/topic/192456-*) |
| github     | (https://github.com/zer0Kerbal/zer0Kerbal/ScrapYard)             |
| curseforge | (https://www.curseforge.com/kerbal/ksp-mods/ScrapYard)           |
| spacedock  | (https://spacedock.info/mod/1746)                                |
| ckan       | ScrapYard                                                        |

## Version 2.2.2.0-release - `<Maintenance>` edition

* 18 Sep 2022
* Released for 1.12.3

### Summary 2.2.2.0

* Maintenance release
* Compatibile version bump to 1.12.3
* Contract Configurator hard dependancy KSP 1.8.1+
* Version .dll's
  * <ScrapYard.dll> v2.2.1.23
  * <ScrapYard_ContractConfigurator.dll> v2.2.1.6
  * not recompiled for this release

### Changes

* Contract Configurator hard dependancy KSP 1.8.1+
  * this is because KSP changed how it handles loading .dll's
  * updates #25 - [BUG 🐞] ScrapYard is borking KSP when Contract Configurator is not installed
* Update License
  * Updated License: GPL-2.0
  * was: Expat-MIT
* closes #54 - Updated  License

### Localization 2.2.2.0

* Initial code localization
  * closes #29 - American English <us-en.cfg>
  * updates #28 - Localization - Master
  * updates #46 - Code Localization

### Status 2.2.2.0

* Issues
  * closes #47 - ScrapYard 2.2.2.0-prerelease `<Maintenance>`
  * closes #48 - 2.2.2.0 Verify Legal Mumbo Jumbo
  * closes #49 - 2.2.2.0 Update Documentation
  * closes #50 - 2.2.2.0 Social Media

---

## Version 2.2.1.0-prerelease - `*t-minus...the final countdown*`

* 2021-09-23
* Released for 1.12.2
* recompile for KSP 1.12.2 using KSP 1.12.2 assemblies (instead of 1.12.0)

### Finally proper credit given to

* original Author [@`Magico13'] - thank you for this wonderful mod!  
* [@`Zelda'] for ideas and support. The legend is real! 🧧
* [@`eightiesboi`] for ideas, support and testing! 🧧

### Updated

* [Expat-MIT.txt]
  * rename from MIT.txt to Expat-MIT.txt to properly reference license type
  * update to include 2021
* NETKan file updated
* Spacedock with 2.2.0.0
* NETKan file updated
* [Changelog.cfg] to most recent standard
* folder structure

### Localization

* Added
  * Folder: ScrapYard/Localization/
    * [us-en.cfg]
      * [readme.md]

### Code

* Issue: LogSpam
  * thank you to @baldamundo and [@jefferyharrell]
  * "fix Of FlowGraph issue by not storing ID in tracker as we already looking for part based on part.Id"
    * should resolve #4
    * thank you @roxik0
* Recompile for
  * KSP 1.12.2
    * .Net 4.7.2
    * C# 9.0
* Update
  * update to ToolsVersion 16
  * lint .csproj's; remove comments
  * [Version.tt] v2.0.0.2
  * [AssemblyFileVersion] since has been included since adoption
  * initial code Localization
    * closes #9 - initial code Localization

### Documentation

* usual spring cleaning and automation
* [ScrapYard_ContractConfigurator.version]
  * for [ScrapYard_ContractConfigurator.dll]
* Update
  * [readme.md] v1.5.4.1

### Automation

* Update
  * [ReleaseLayout] v1.2.2.2
  * [_buildJSON] v1.3.3.6
  * [_buildRelease] v1.1.1.2
  * [_release] v1.0.2.0
  * [_deploy] v1.1.1.0

### Status

* Bug Tracker
  * closed #4 - logspam
  * updated #9 us-en.cfg should be complete
  * ScrapYard compatibility with RealChute - thank you genehwung (closes #11)
* Possible future changes
  * Clean the ScrapYard #12
  * Flowgraph Logspam #4
  * Used chutes fitted to ship are already deployed #3
  * add a wiki (user driven)

## Version - 2.2.0.0 - `final countdown...`

* 19 JuL 2021
* Released for 1.12.1
	CHANGE
	{
  *  Code
  * recompile for KSP 1.12.1
  * use .net 4.7.2
  * use C# 9.0
  * update to Version.tt [v2.0.0.0] 		change = Update
  * patches to use :NEEDS:[ScrapYard]:FOR[ScrapYard]
  * usual spring cleaning and automation
  * folder structure
  * to modern back-end automation
*  correct changelog thank you to 7ranceaddic7
*  resolves #2
	}
	VERSION
	{
		version = 2.1.1.0
		versionName = now with less magicore!
  *  removed need for magicore dependency
  *  thank you to @magico13 and @linuxgurugamer for the code
  *  license MIT
	}
	VERSION
	{
		version = 2.1.0.0
		versionName = Kanford and Sons - Back in Business!
  *  >>-- Adoption by zer0Kerbal
  *  recompiled for KSP 1.9.1
  *  recompiled against .NET 4.8
  *  updated file structure
  *  updated .csproj to zer0Kerbal's 
  *  updated to zer0Kerbal's automated build process
  *  added CONTRIBUTION.md
  *  added automated process to generate Readme.htm from Readme.md
  *  updated Spacedock
  *  created Curseforge
  *  create new forum thread
	}
	VERSION
	{
		version = 2.0
  *  Recompiled against KSP 1.8 / .Net 4.7.2
  *  Added support for MADLAD's Install Validator
	}
	VERSION
	{
		version = 1.1.3
  *  Recompiled against KSP 1.7.2
  *  using KRASH and KCT together will no longer cause the universe to explode
	}
	VERSION
	{
		version = 1.1.2
  *  Recompiled against KSP 1.7
  *  Fixed bug where KRASH simulations would increment the build count
  *  Added support for Kerbal Changelog
	}
	VERSION
	{
		version = v1.1.0.107 (2018-03-18)
  *  Added new event: "OnSYInventoryAppliedToPart". Fired when pressing "apply" from main UI on an existing part.
  *  Bug fix where Ids were not being set correctly when copying InventoryParts, which affected any parts that were added to the inventory and then used in the same scene (editing vessels in KCT, for instance)
  *  Changed Vessel tracking to fully remove a vessel from the list when setting the tracking state to false to avoid the list filling up unnecessarily.
	}
	VERSION
	{
		version = v1.0.1.104 (2018-03-17)
  *  Fixed an issue where "persistentId" was listed as "persistentID" that was breaking the ProcessVessel API call.
  *  Fixed an exception that would occur when loading a game because of the settings class.
  *  Changed the message logged when logging a new build to avoid confusion.
	}
	VERSION
	{
		version = v1.0.0.102 (2018-03-14)
  *  Updated to KSP 1.4.1
  *  Support for ContractConfigurator for adding/removing parts from inventory as part of a contract (details soon).
  *  Considerable performance improvements, but some combinations of mods/settings may still see lag spikes in editor.
  *  New part category (in the advanced section) with only parts that are in the inventory.
  *  UI refactor. All windows are resizeable (grab bottom/right sides). Main inventory window prevents click through, even when holding a part over the part panel.
  *  Switched to KSP's stock persistentId system. Old parts should update correctly and not need any manual intervention. Let me know if parts aren't "sticking" when they apply, but I think I fixed that.
  *  The main window retains it's last state when re-entering the editor.
  *  Added options to change how often things are recalculated in the editor (turn it up to be less often, but less frequent lag spikes) and to enable debug logging (prints more to the log, enable if you're experiencing a bug).
  *  Explicit TweakScale support so that it will properly scale everything when selecting/applying from the inventory.
  *  Numerous other small tweaks and fixes.
	}
	VERSION
	{
		version = v0.9.6.70 (2017-10-17)
  *  Updated to KSP 1.3.1
  *  Several additions and changes to the ScrapYard API
  *  First release of the WIP part selector UI. Very WIP at the moment. Known issues with modules like TweakScale.
	}
	VERSION
	{
		version = v0.9.5.57 (2017-06-13)
  *  Added "Auto-Apply" option to automatically apply the inventory as you build a vessel.
  *  Window is now movable and position is saved.
  *  Allow dry costs to differ by 1 fund and still be considered the same, due to floating point inconsistencies.
  *  Updated to KSP 1.3 (not backwards compatible with 1.2.2, sorry.)
  *  Added button to reset the vessel back to "new".
  *  Bug fixes to not auto-apply non-stop, check the vessel when starting the editor, and only do work once a second instead of twice.
	}
	VERSION
	{
		version = v0.9.4.51 (2017-05-14)
  *  Added ability to sell/discard parts in the editor by dropping them on the ScrapYard button. Selling currently occurs at 100% value, that will change in the future.
  *  When overriding funds, the cost display in the editor updates to show the cost after accounting for the inventory. Purely visual, so if you can't afford the whole vessel before the inventory's help then you won't be able to launch.
  *  Added OnSYTrackerUpdated event. Fires when the part tracker registers a build.
	}
	VERSION
	{
		version = v0.9.3.48 (2017-05-13)
  *  New icon thanks to flaticon.com. Creators: Icomoon and Freepik
  *  Updated the Part Tracker to track builds/uses for new uses, inventoried uses, and total uses.
  *  With the updated MagiCore, now should support string comparison in if statements with "seq" and "sneq" for equals and not equals, and also supports "true" as "1" and "false" as "0".
	}
	VERSION
	{
		version = v0.9.2.44 (2017-05-10)
  *  Fixed a few bugs that were causing forbidden templates to not match correctly.
	}
	VERSION
	{
		version = v0.9.1.41 (2017-05-09)
  *  Added several methods to the API for interacting with individual parts and the inventory.
  *  Tried to broaden the API a bit: takes IEnumerables and returns ILists instead of requiring List for both.
  *  Changed MODULE_TEMPLATE to SY_MODULE_TEMPLATE and FORBIDDEN_TEMPLATE to SY_FORBIDDEN_TEMPLATE
  *  Added part blacklist that takes a part name (exact, no Regex) and prevents storing the part if it's on the list
  *  EVA kerbals are no longer added to the inventory per the blacklist.
  *  Templates and Blacklist are referenced via the GameDatabase, meaning they should support Module Manager but at the very least you could create your own .cfg files in your own directory and have them be added (MM should allow changing existing ones though).
  *  Template file (and blacklist) now lives in /ScrapYard instead of /ScrapYard/PluginData so it can be loaded.
	}
	VERSION
	{
		version = v0.9.0.37 (2017-05-05)
  *  Initial Beta Release
	}
}

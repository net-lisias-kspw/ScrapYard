---
permalink: /ManualInstallation.html
title: ManualInstallation
---

<!-- ManualInstallation.md v1.1.0.0
Not So SimpleConstruction! (NSSC)
created: 01 Oct 2019
updated: 02 Mar 2022 -->

<!-- based upon work by Lisias -->

# Not So SimpleConstruction! (NSSC)

Adds Mallet, Survey Stake, Recycler, Disposable Pad, Orbital Dock and Control Reference; and turns Cupola module to Survey Station. Requires SimpleConstruction! for Kerbal Space Program.

## Installation Instructions

### Using CurseForge/OverWolf app or CKAN

You should be all good! (check for latest version on CurseForge)

### If Downloaded from CurseForge/OverWolf manual download

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
  * Delete `<KSP_ROOT>/GameData/NotSoSimpleConstruction`
* Extract the package's `NotSoSimpleConstruction/` folder into your KSP's as follows:
  * `<PACKAGE>/SimpleConstruction` --> `<KSP_ROOT>/GameData/NotSoSimpleConstruction`
    * Overwrite any preexisting file.

### If Downloaded from SpaceDock / GitHub / other

To install, place the GameData folder inside your Kerbal Space Program folder:

* **REMOVE ANY OLD VERSIONS OF THE PRODUCT BEFORE INSTALLING**, including any other fork:
  * Delete `<KSP_ROOT>/GameData/NotSoSimpleConstruction`
* Extract the package's `GameData/NotSoSimpleConstruction` folder into your KSP's as follows:
  * `<PACKAGE>/GameData/NotSoSimpleConstruction` --> `<KSP_ROOT>/GameData`
    * Overwrite any preexisting file.

## The following file layout must be present after installation

```
<KSP_ROOT>
  [GameData]
    [ExtraplanetaryLaunchpads]
      [Localization]
        ...
      [Texture]
        ...
      [UI]
        ...
      License.txt
      License-KS.txt
    [NotSoSimpleConstruction]
      [Assets]
        ...
      [Compatibility]
        ...
      [Configs]
        ...
      [Localization]
        ...
      [Parts]
        ...
      #.#.#.#.htm
      changelog.md
      GPLv3.txt
      readme.htm
      NotSoSimpleConstruction.version
    [SimpleConstruction]
      [Agencies]
        ...
      [Compatibility]
        ...
      [Contracts]
        ...
      [Flags]
        ...
      [Localization]
        ...
      [Parts]
        ...
      [Plugins]
        ...
      #.#.#.#.htm
      changelog.md
      Expat-MIT.txt
      readme.htm
      SimpleConstruction.version
    ...
  KSP.log
  ...
```

### Dependencies

* [Module Manager /L][mm]
* [SimpleConstruction! (SCON!)][scon]

[scon]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-* "SimpleConstruction! (SCON!)"
[mm]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"

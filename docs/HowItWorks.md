---
permalink: /HowItWorks.html
title: HowItWorks
description: the flat-pack Kiea instructions, written in Kerbalese, unusally present
tags: installation,directions,page,kerbal,ksp,zer0Kerbal,zedK
---

<!-- HowItWorks.md v1.1.0.0
ScrapYard (SYD)
created: 01 Oct 2019
updated: 02 Mar 2022 -->

# ScrapYard (SYD) [WIP]

*help out by enhancing this page*

[Home](./index.html)

## How it works

### The bit you are actually interested in

ScrapYard is a mod that provides a part inventory that can be shared between multiple mods. Parts are added to the inventory when you recover a vessel and are removed from the inventory when you build a new vessel. If you have ever played with Kerbal Construction Time, it's a significantly improved version of the part inventory that KCT had, that is also able to be used by other mods.

### As of writing, ScrapYard does the following

* Parts are added to the inventory automatically upon vessel recovery
* Parts are applied in the editor (not automatically like with KCT)
* Parts are then pulled from the inventory on build (mods can change when this happens)
* Parts are stored individually in the inventory along with any modules that “define” the part (think TweakScale and Procedural Parts)
* The number of times “like” parts are used is tracked and available for mods, both total uses and number of builds (KCT’s part tracker feature, expanded)
* Parts are trackable from the moment they are placed in the editor until they are removed from the game via a unique ID that transcends recovery and new builds
* The number of times an individual part is recovered is tracked, perfect for consumption by part failure mods
* (WIP) Funds can be overridden so that using parts from the inventory do not contribute to the cost of the vessel. You do still need to have the full amount of funds (for now).
* ContractConfigurator support for adding or removing parts from the inventory as part of contracts

### Dependencies

* *either*
  * [Module Manager /L][mml]
  * [Module Manager][mm]

[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"

<!-- this file CC BY-NC-ND 4.0 by zer0Kerbal -->

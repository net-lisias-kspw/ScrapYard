<!-- Readme.md v1.5.4.1
ScrapYard (SYD)
created: 01 Oct 19
updated: 23 Sep 2021 -->

[MODVERSION]: 2.2.1.0
[KSPVERSION]: 1.12.2

## Download on [Curseforge][CURSFG:url] or [Github][GITHUB:url] or [SpaceDock][SPCDCK:url]. 

##### Available on [CKAN][CKAN:url] as _`ScrapYard`._


# ScrapYard (SYD)

A common part inventory mod for Kerbal Space Program

#### Adopted by [`@zer0Kerbal`][LINK:zer0kerbal] from [`@severedsolo`][LINK:severedsolo], originally by [`Magico13`][LINK:magico13]  

![Mod Version][MOD:shld:latest] ![KSP version][KSP:shld]  [![License Expat-MIT][LICENSE:shld]][LICENSE:link]  

[![Curseforge][CURSFG:shld]][CURSFG:url] [![CKAN][CKAN:shd]][CKAN:url] [![GitHub][GITHUB:shld]][GITHUB:url] [![SpaceDock][SPCDCK:shld]][SPCDCK:url]  

![Code][CODE:shld] ![KSP-AVC][AVC:shld] ![Validate AVC .version files][AVCVLD:shld]   

###### _brought to you by KGEx_

***

## Description 

### Preamble by [@severedsolo][LINK:severedsolo]: 
> So you may have heard that @magico13 is giving up modding KSP. I've got the honour of taking over support for ScrapYard, because it makes sense as I have my own mod that depends on it (Oh Scrap!). I want to take this opportunity to thank magico13 for all his hard work and contributions to the community over the years, as I know that my own KSP experience would be much poorer without his mods. Anyway, enough from me.

### The bit you are actually interested in

> ScrapYard is a mod that provides a part inventory that can be shared between multiple mods. Parts are added to the inventory when you recover a vessel and are removed from the inventory when you build a new vessel. If you have ever played with Kerbal Construction Time, it's a significantly improved version of the part inventory that KCT had, that is also able to be used by other mods.

## Features

### As of writing, ScrapYard does the following:
- Parts are added to the inventory automatically upon vessel recovery
- Parts are applied in the editor (not automatically like with KCT)
- Parts are then pulled from the inventory on build (mods can change when this happens)
- Parts are stored individually in the inventory along with any modules that “define” the part (think TweakScale and Procedural Parts)
- The number of times “like” parts are used is tracked and available for mods, both total uses and number of builds (KCT’s part tracker feature, expanded)
- Parts are trackable from the moment they are placed in the editor until they are removed from the game via a unique ID that transcends recovery and new builds
- The number of times an individual part is recovered is tracked, perfect for consumption by part failure mods
- (WIP) Funds can be overridden so that using parts from the inventory do not contribute to the cost of the vessel. You do still need to have the full amount of funds (for now).
- ContractConfigurator support for adding or removing parts from the inventory as part of contracts
  
***

![Flag][IMG:flg:0]  

![Hero Image][IMG:hero:0]  

***

### As a player, why do I want this? 

> If you are using Kerbal Construction Time, all balance is assumed you have this mod. It will substantially reduce build times for both vessels that use parts from the inventory and new vessels that use frequently used parts due to the part tracker. As of writing, no other mods are using this framework, but when they do this mod may be required. And this mod can be used by itself with the override funds option to play with a very different play style.

### As a mod developer, why do I want this?

> There are numerous reasons you might want to integrate with ScrapYard (with a hard dependency or a soft dependency, both options are offered), here are just a few that I can think of off the top of my head:
> 
> - ScrapYard provides a way to uniquely track a part during its entire life cycle, from the moment it is placed in the editor until the time it is removed from the game. That includes surviving through multiple recoveries and launches. I imagine part failure mods might get the most use out of this, but surprise me!
> - By using a developed, common system you don’t need to worry about implementing your own part inventory and automatically gain support with other mods. Spend more time writing new features instead of rewriting something that exists.
> - Fine control over the modules that are stored with a part. Once Module Manager support for module templates is added, you can create a new module and a module manager patch to automatically store your module and its data with a part through its entire lifecycle. Module templates use MagiCore’s MathParser to allow for logic processing within the config file (currently limited to just numbers, strings will likely be added soon). Until Module Manager is supported, you can just edit the ModuleTemplates.cfg file directly. ﻿
> - Get information about how often parts are used on a total used and number of builds basis. This is referred to as either the Part Tracker or the "Like" Part Tracker since it just tracks parts that are like each other (same name).
> - Many more that I can’t think of off the top of my head

#### Mods using ScrapYard:

> - [Kerbal Construction Time][thread:kct] by [@linuxgurugamer][LINK:linuxgurugamer] / [@magico13][LINK:magico13]  
> - [Oh Scrap!][thread:ohscrap] by [@severedsolo][LINK:severedsolo] / [@zer0Kerbal][LINK:zer0Kerbal]

#### Cabin notes:   

> - Feature Complete
> - Future Plans: lol. 
>   - Except compatibility patches, keep it working with future KSP updates.
>   - Am open to adding more features, great project for someone!
>   - Have a request? Glad to have them, kindly submit through GitHub.
> - I have not personally tested the patches   

***

### Localization _work in progress_

> - [x]  ![][EN] English - in progress 
> - [ ]  
>
> HELP WANTED - See the [README in the Localization folder][LINK:local] for instructions for adding or improving translations for languages other than English. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections solicited and welcome!* 

***

### How to support  

[![Support][PAYPAL:img]][PAYPAL:url] [![Github Sponsor][GSPONS:img]][GSPONS:url] [![Patreon][PATREON:img]][PATREON:url] [![Buy zer0Kerbal a snack][BMCC:img]][BMCC:url] 

***

### See More

- Discussions and news on this mod: See [Discussions][MOD:disc] or [KSP Forums][MOD:thread]  
- Changelog Summary for more details of changes : See [ChangeLog][MOD:clog]  
- Known Issues for more details of feature requests and known issues : See [Known Issues][MOD:known]  

***

### Installation Directions:

- Use  
[![CKAN][CKAN:img]][CKAN:url]


### Dependencies  

- [x]  [Kerbal Space Program][KSP:url] [![][KSP:shld]][KSP:url] [^1]  
- [x]  [Module Manager][thread:mm]  

### Recommends  

- [x]  [Module Manager][thread:mm] [^2]  
- [x]  [Comprehensive Kerbal Archive Network (CKAN)][CKAN:url] [^3]  
- [x]  [OhScrap!][thread:OHS]  

### Suggests

#### Mods that benefit ScrapYard (SYD)

- [x]  [Kerbal Change Log][thread:kcl]  
- [x]  [StageRecovery][thread:sr]  
- [x]  [Kerbal Construction Time][thread:kct]  
- [x]  [Magico13's Modlets][thread:m13] _Sensible Screenshot, Dated QuickSaves, etc._ 

#### Other fun mods by [`zed'K`][LINK:zer0Kerbal] 

- [x]  [KaboOom! (BOOM)][thread:BOOM] another way to not go to space today  
- [x]  [SimpleLogistics! (SLOG!)][thread:SLOG!]  
- [ ]  [Foundations (FND) - beta][thread:FND] ***Helps prevent ground constructions from floating away :)*** 
- [x]  [Biomatic (BIO)][thread:BIO]
- [x]  [Komplexity (KPLX)][thread:KPLX]  
- [x]  [Mini Sample Return Capsule (MSRC)][thread:MSRC] 
- [x]  [Pteron (MSRV)][thread:MSRV] 
- [x]  [Jack-O-Lantern (JACK)][thread:JACK]  
- [x]  [MoarKerbals(MOAR)][thread:MK]  
- [x]  [On Demand Fuel Cells (ODFC))][thread:ODFC]  
- [x]  [Field Training Facility (FTF)][thread:FTF]  
- [x]  [Field Training Lab (FTL)][thread:FTL]  
- [x]  [Docking Port Descriptions(DPD)][thread:DPD]  
- [x]  [PicoPort Shielded (PPS)][thread:PPS]  
- [x]  [Transparent Command Pods) (TCP)][thread:TCP]  
- [x]  [More Hitchhikers) (MHH)][thread:MHH]  
- [x]  [B9 Stock Patches (B9S)][thread:B9S] 
- [x]  [DaMichel's AeroRadial (DAR)][thread:DAR]  
- [x]  [DaMichel's CargoBays (DCB)][thread:DCB]  
- [x]  [DaMichel's Fuselage (DMF)][thread:DMF]  
- [x]  [DaMichel's Spherical Tanks (DST)][thread:DST]  
- [x]  [KerGuise Experimental Engineering (KGEx)][thread:KGEX]  
- [x]  [The Gold Standard (GOLD)][thread:GOLD]  
- [x]  [Keridian Dynamics Vessel Assembly (KDVA)][thread:KDVA]
- [x]  [Olympic's ARP Icons (ARPI)][thread:ARPI]  
- [x]  [Stack Inline Lights (SIL)][thread:SIL]  
- [x]  [Stack Inline Lights - Patches (SILP)][thread:SILP]  
- [x]  [Solar Science (SOLS)][thread:SOLS]  
- [x]  [Stork Delivery System (SDS)][thread:SDS]
- [x]  [Simple Cargo Solutions by AxialAeropace(SCS)][thread:SCS]

### Supports
- [x]  [Kerbal KRASH systen][thread:kks]  
- [x]  [TweakScale][thread:twk]  
- [x]  [RemoteTech][thread:rt]  
- [x]  [FAR][thread:far]  
- [x]  [Contract Configurator][thread:cc]  

### Conflicts

- none known

### Replaces  

- none

### Tags  

- plugin, config, career

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
<p><b>*red box below is a link to forum post on how to get support*</p>  
<a href = "https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
  <p><img src = "https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a></div>

![hero shot][IMG:hero:1]  

### Credits and Special Thanks 

- [@`SiriusSam`][LINK:siriussame] for the original idea of creating a separate part inventory way back in 2014 and for the name
- [@`enneract`][LINK:enneract] for discussion and design help.
- [@`Zelda'][LINK:zelda] for ideas and support
- [@`Zelda'][LINK:zelda] for ideas and support 🧧 
- [`eightiesboi`][LINK:eightiesboi] for ideas, support and testing! 🧧

### Legal Mumbo Jumbo ( _provenance_ )

#### Current (2) - [`zer0Kerbal`][LINK:zer0Kerbal] 

> Forum: [Thread][MOD:thread] - Source: [GitHub][GITHUB:url]  
> License: [![License Expat-MIT][LICENSE:shld]][LICENSE:link]  
> *** All bundled mods are distributed under their own licenses ***  
> *** All art assets (textures, models, animations) are distributed under their own licenses ***  

#### Maintainer (1)  [`severedsolo`][LINK:severedsolo] 

> Forum: [Thread][MOD:1:thread]  - Spacedock [Download][MOD:1:download] - Source: [GitHub][MOD:1:source]  
> License: [![License Expat-MIT][LICENSE:shld]][LICENSE:link]  

#### Original (0) - Author: [`Magico13`][LINK:magico13]

> [Thread][MOD:0:thread]  - Spacedock [Download][MOD:0:download] - Source: [GitHub][MOD:0:source] 
> License: [![License Expat-MIT][LICENSE:shld]][LICENSE:link] 

-----

<!-- graphical links to downloads -->

[![][CURSFG:img]][CURSFG:url] [![][GITHUB:img]][GITHUB:url] [![][SPCDCK:img]][SPCDCK:url]  

##### Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date 

![IMG:hero:1] 

###### v2.2.1.0 original: 01 Oct 2019 zed'K | updated: 23 Sep 2021 zed'K

<!-- mod links -->

[MOD:clog]: https://github.com/zer0Kerbal/ScrapYard/Changelog.cfg "Changelog"
[MOD:disc]: https://github.com/zer0Kerbal/ScrapYard/discussions "Discussions"
[MOD:wiki]: https://github.com/zer0Kerbal/ScrapYard/ "Wiki"
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/192456-* "ScrapYard Forum Thread"
[MOD:known]: https://github.com/zer0Kerbal/ScrapYard/wiki/Known-Issues "Known Issues"
[MOD:issues]: https://github.com/zer0Kerbal/ScrapYard/issues "GitHub Issues"
[LINK:local]: https://github.com/zer0Kerbal/ScrapYard/blob/master/GameData/ScrapYard/Localization/readme.md "Localization"
[MOD:contrib]: https://github.com/zer0Kerbal/ScrapYard/blob/master/.github/CONTRIBUTING.md "Contributing"
[MOD:license]: https://github.com/zer0Kerbal/ScrapYard/blob/master/LICENSE  "Github License"

[MOD:shld:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/mod.json&labelColor=bada55

[CODE:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/code.json

<!--- original mod -->
[MOD:1:source]: https://github.com/severedsolo/ScrapYard "Original Github"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/178641-* "severedsolo's Thread"
[MOD:1:download]: https://spacedock.info/mod/1746 "SpaceDock"

[MOD:0:source]: https://github.com/magico13/ScrapYard "Original Github"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/160257-* "magico13's Thread"
[MOD:0:download]: https://spacedock.info/mod/1746 "SpaceDock"

<!--- license -->
[LICENSE:link]: https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/LICENSE "Expat/MIT"
[LICENSE:logo]:    https://i.postimg.cc/bvjfsMP5/MIT-17x17.png "Expat/MIT"  
[LICENSE:shld]: https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/img/Expat-MIT.svg "Expat-MIT"  
[LICENSE:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/license.json&logoColor=white&logo=data:image/svg+xml;base64,PHN2ZyAgIHhtbG5zOmRjPSJodHRwOi8vcHVybC5vcmcvZGMvZWxlbWVudHMvMS4xLyIgICB4bWxuczpjYz0iaHR0cDovL2NyZWF0aXZlY29tbW9ucy5vcmcvbnMjIiAgIHhtbG5zOnJkZj0iaHR0cDovL3d3dy53My5vcmcvMTk5OS8wMi8yMi1yZGYtc3ludGF4LW5zIyIgICB4bWxuczpzdmc9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIiAgIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgICB4bWxuczpzb2RpcG9kaT0iaHR0cDovL3NvZGlwb2RpLnNvdXJjZWZvcmdlLm5ldC9EVEQvc29kaXBvZGktMC5kdGQiICAgeG1sbnM6aW5rc2NhcGU9Imh0dHA6Ly93d3cuaW5rc2NhcGUub3JnL25hbWVzcGFjZXMvaW5rc2NhcGUiICAgd2lkdGg9IjI1NiIgICBoZWlnaHQ9IjI1NiIgICBpZD0ic3ZnMiIgICB2ZXJzaW9uPSIxLjEiICAgaW5rc2NhcGU6dmVyc2lvbj0iMC40NyByMjI1ODMiICAgc29kaXBvZGk6ZG9jbmFtZT0ibGljZW5zZXMtbWl0LnN2ZyI+ICA8ZGVmcyAgICAgaWQ9ImRlZnM0Ij4gICAgPGlua3NjYXBlOnBlcnNwZWN0aXZlICAgICAgIHNvZGlwb2RpOnR5cGU9Imlua3NjYXBlOnBlcnNwM2QiICAgICAgIGlua3NjYXBlOnZwX3g9IjAgOiA1MjYuMTgxMDkgOiAxIiAgICAgICBpbmtzY2FwZTp2cF95PSIwIDogMTAwMCA6IDAiICAgICAgIGlua3NjYXBlOnZwX3o9Ijc0NC4wOTQ0OCA6IDUyNi4xODEwOSA6IDEiICAgICAgIGlua3NjYXBlOnBlcnNwM2Qtb3JpZ2luPSIzNzIuMDQ3MjQgOiAzNTAuNzg3MzkgOiAxIiAgICAgICBpZD0icGVyc3BlY3RpdmUxMCIgLz4gICAgPGlua3NjYXBlOnBlcnNwZWN0aXZlICAgICAgIGlkPSJwZXJzcGVjdGl2ZTI4ODQiICAgICAgIGlua3NjYXBlOnBlcnNwM2Qtb3JpZ2luPSIwLjUgOiAwLjMzMzMzMzMzIDogMSIgICAgICAgaW5rc2NhcGU6dnBfej0iMSA6IDAuNSA6IDEiICAgICAgIGlua3NjYXBlOnZwX3k9IjAgOiAxMDAwIDogMCIgICAgICAgaW5rc2NhcGU6dnBfeD0iMCA6IDAuNSA6IDEiICAgICAgIHNvZGlwb2RpOnR5cGU9Imlua3NjYXBlOnBlcnNwM2QiIC8+ICA8L2RlZnM+ICA8c29kaXBvZGk6bmFtZWR2aWV3ICAgICBpZD0iYmFzZSIgICAgIHBhZ2Vjb2xvcj0iI2ZmZmZmZiIgICAgIGJvcmRlcmNvbG9yPSIjNjY2NjY2IiAgICAgYm9yZGVyb3BhY2l0eT0iMS4wIiAgICAgaW5rc2NhcGU6cGFnZW9wYWNpdHk9IjAuMCIgICAgIGlua3NjYXBlOnBhZ2VzaGFkb3c9IjIiICAgICBpbmtzY2FwZTp6b29tPSIwLjk4OTk0OTQ5IiAgICAgaW5rc2NhcGU6Y3g9IjEzMy40NzU2MSIgICAgIGlua3NjYXBlOmN5PSIxMTUuMDYyMTciICAgICBpbmtzY2FwZTpkb2N1bWVudC11bml0cz0icHgiICAgICBpbmtzY2FwZTpjdXJyZW50LWxheWVyPSJsYXllcjEiICAgICBzaG93Z3JpZD0iZmFsc2UiICAgICBpbmtzY2FwZTp3aW5kb3ctd2lkdGg9Ijg3NiIgICAgIGlua3NjYXBlOndpbmRvdy1oZWlnaHQ9IjY4NCIgICAgIGlua3NjYXBlOndpbmRvdy14PSI3IiAgICAgaW5rc2NhcGU6d2luZG93LXk9IjI5OSIgICAgIGlua3NjYXBlOndpbmRvdy1tYXhpbWl6ZWQ9IjAiIC8+ICA8bWV0YWRhdGEgICAgIGlkPSJtZXRhZGF0YTciPiAgICA8cmRmOlJERj4gICAgICA8Y2M6V29yayAgICAgICAgIHJkZjphYm91dD0iIj4gICAgICAgIDxkYzpmb3JtYXQ+aW1hZ2Uvc3ZnK3htbDwvZGM6Zm9ybWF0PiAgICAgICAgPGRjOnR5cGUgICAgICAgICAgIHJkZjpyZXNvdXJjZT0iaHR0cDovL3B1cmwub3JnL2RjL2RjbWl0eXBlL1N0aWxsSW1hZ2UiIC8+ICAgICAgICA8ZGM6dGl0bGU+PC9kYzp0aXRsZT4gICAgICA8L2NjOldvcms+ICAgIDwvcmRmOlJERj4gIDwvbWV0YWRhdGE+ICA8ZyAgICAgaW5rc2NhcGU6bGFiZWw9IkxheWVyIDEiICAgICBpbmtzY2FwZTpncm91cG1vZGU9ImxheWVyIiAgICAgaWQ9ImxheWVyMSIgICAgIHRyYW5zZm9ybT0idHJhbnNsYXRlKDAsLTc5Ni4zNjIxOCkiPiAgICA8cGF0aCAgICAgICBzb2RpcG9kaTp0eXBlPSJhcmMiICAgICAgIHN0eWxlPSJmaWxsOiNmZmZmZmY7ZmlsbC1vcGFjaXR5OjE7ZmlsbC1ydWxlOm5vbnplcm87c3Ryb2tlOiMwMDAwMDA7c3Ryb2tlLXdpZHRoOjE1LjM0OTE3MTY0O3N0cm9rZS1saW5lY2FwOnJvdW5kO3N0cm9rZS1taXRlcmxpbWl0OjQ7c3Ryb2tlLW9wYWNpdHk6MTtzdHJva2UtZGFzaGFycmF5Om5vbmUiICAgICAgIGlkPSJwYXRoMzY4NSIgICAgICAgc29kaXBvZGk6Y3g9IjEzMi4zMjk5OSIgICAgICAgc29kaXBvZGk6Y3k9IjEzNC43ODE2OSIgICAgICAgc29kaXBvZGk6cng9IjExMy4xMzcwOCIgICAgICAgc29kaXBvZGk6cnk9IjEwOS4wOTY0NyIgICAgICAgZD0ibSAyNDUuNDY3MDYsMTM0Ljc4MTY5IGEgMTEzLjEzNzA4LDEwOS4wOTY0NyAwIDEgMSAwLC0wLjAwMiIgICAgICAgdHJhbnNmb3JtPSJtYXRyaXgoMS4wNTcyMjg1LDAsMCwxLjA5MzAyMjcsLTEyLjA0MTI5MSw3NzcuNTQ3ODIpIiAgICAgICBzb2RpcG9kaTpzdGFydD0iMCIgICAgICAgc29kaXBvZGk6ZW5kPSI2LjI4MzE2NzkiICAgICAgIHNvZGlwb2RpOm9wZW49InRydWUiIC8+ICAgIDx0ZXh0ICAgICAgIHhtbDpzcGFjZT0icHJlc2VydmUiICAgICAgIHN0eWxlPSJmb250LXNpemU6Ni44OTQ2NjU3MnB4O2ZvbnQtc3R5bGU6bm9ybWFsO2ZvbnQtdmFyaWFudDpub3JtYWw7Zm9udC13ZWlnaHQ6bm9ybWFsO2ZvbnQtc3RyZXRjaDpub3JtYWw7bGluZS1oZWlnaHQ6MTI1JTtmaWxsOiMwMDAwMDA7ZmlsbC1vcGFjaXR5OjE7c3Ryb2tlOm5vbmU7Zm9udC1mYW1pbHk6QXJpYWw7LWlua3NjYXBlLWZvbnQtc3BlY2lmaWNhdGlvbjpBcmlhbCIgICAgICAgeD0iMzQuNDA5NzU2IiAgICAgICB5PSI4NjkuMDYxMDQiICAgICAgIGlkPSJ0ZXh0MzcxMCIgICAgICAgc29kaXBvZGk6bGluZXNwYWNpbmc9IjEyNSUiICAgICAgIHRyYW5zZm9ybT0ic2NhbGUoMC44OTA4MDUxLDEuMTIyNTgpIj48dHNwYW4gICAgICAgICBzb2RpcG9kaTpyb2xlPSJsaW5lIiAgICAgICAgIGlkPSJ0c3BhbjM3MTIiICAgICAgICAgeD0iMzQuNDA5NzU2IiAgICAgICAgIHk9Ijg2OS4wNjEwNCIgICAgICAgICBzdHlsZT0iZm9udC1zaXplOjEyNC4xMDM5NzMzOXB4O2ZvbnQtc3R5bGU6bm9ybWFsO2ZvbnQtdmFyaWFudDpub3JtYWw7Zm9udC13ZWlnaHQ6Ym9sZDtmb250LXN0cmV0Y2g6bm9ybWFsO3RleHQtYWxpZ246c3RhcnQ7bGluZS1oZWlnaHQ6MTI1JTt3cml0aW5nLW1vZGU6bHItdGI7dGV4dC1hbmNob3I6c3RhcnQ7Zm9udC1mYW1pbHk6QXJpYWw7LWlua3NjYXBlLWZvbnQtc3BlY2lmaWNhdGlvbjpBcmlhbCBCb2xkIj5NSVQ8L3RzcGFuPjwvdGV4dD4gIDwvZz48L3N2Zz4= "Expat-MIT"

<!--- AVC --->
[AVC:shld]:     https://img.shields.io/badge/KSP-AVC--supported-brightgreen.svg?labelColor=black&style=plastic
[AVCVLD:shld]:    https://github.com/zer0Kerbal/ScrapYard/workflows/Validate%20AVC%20.version%20files/badge.svg

<!--- release links -->
<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png "CKAN"
[CKAN:url]: http://forum.kerbalspaceprogram.com/index.php?/topic/197082-* "CKAN"
[CKAN:shd]: https://img.shields.io/badge/CKAN-ScrapYard-blue.svg?labelColor=black&style=plastic&logo=data:image/svg+xml;base64,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 "CKAN"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/ScrapYard "Curseforge"
[CURSFG:img]: https://i.postimg.cc/RZNyB5vP/Download-On-Curse.png "Curseforge"
[CURSFG:shld]: https://img.shields.io/badge/CurseForge-Listed-blue.svg?labelColor=black&style=plastic&logo=curseforge "Curseforge"  

[GITHUB:url]: https://github.com/zer0Kerbal/ScrapYard/ "GitHub"
[GITHUB:img]: https://i.imgur.com/RE4Ppr9.png "GitHub"
[GITHUB:shld]: https://img.shields.io/badge/Github-Indexed-blue.svg?labelColor=black&style=plastic&logo=github "GitHub"

[SPCDCK:url]: https://spacedock.info/mod/1746 "SpaceDock"
[SPCDCK:img]: https://i.imgur.com/m0a7tn2.png "SpaceDock"
[SPCDCK:shld]:  https://img.shields.io/badge/SpaceDock-Listed-blue.svg?labelColor=black&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/MiniSampleReturnCapsule/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"

<!-- zer0Kerbal mods -->
[thread:MK]: https://forum.kerbalspaceprogram.com/index.php?/topic/191525-* "MoarKerbals"
[thread:B9S]: https://forum.kerbalspaceprogram.com/index.php?/topic/190870-* "B9 Stock Switches"
[thread:BIO]: https://forum.kerbalspaceprogram.com/index.php?/topic/191426-* "Biomatic"
[thread:DAR]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's AeroRadial"
[thread:DCB]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's CargoBays"
[thread:DMF]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's Fuselage"
[thread:DPD]: https://forum.kerbalspaceprogram.com/index.php?/topic/192184-* "Docking Port Descriptions"
[thread:DST]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's Spherical Tanks"
[thread:FTF]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-* "Field Training Facility"
[thread:FTL]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-* "Field Training Lab"
[thread:FND]: https://forum.kerbalspaceprogram.com/index.php?/topic/51430-* "Foundations - in beta now"
[thread:JET]: https://forum.kerbalspaceprogram.com/index.php?/topic/138441-* "Jettison"
[thread:MHH]: https://forum.kerbalspaceprogram.com/index.php?/topic/188246-* "More Hitchhikers"
[thread:NUK]: https://forum.kerbalspaceprogram.com/index.php?/topic/21466-* "Nuke Tiny Parts"
[thread:OHS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-* "Oh Scrap!"
[thread:PPS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192187-*  "Shielded PicoPort"
[thread:SCS]: https://github.com/zer0Kerbal/SimpleCargo "Simple Cargo Solutions (SCS)"
[thread:SDS]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "Stork Delivery System (SDS)"
[thread:SIL]: https://forum.kerbalspaceprogram.com/index.php?/topic/193050-* "Stock Inline Lights"
[thread:SYD]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-* "ScrapYard"
[thread:TCP]: https://forum.kerbalspaceprogram.com/index.php?/topic/187495-* "Transparent Command Pods"
[thread:ARPI]: https://forum.kerbalspaceprogram.com/index.php?/topic/193078-* "Olympic1's ARP Icons"
[thread:BOOM]: https://forum.kerbalspaceprogram.com/index.php?/topic/192938-* "KaboOom!"
[thread:GOLD]: https://forum.kerbalspaceprogram.com/index.php?/topic/203990-* "[The Gold Standard! (GOLD)"
[thread:JACK]: https://forum.kerbalspaceprogram.com/index.php?/topic/189466-* "Jack-O'-Lantern"
[thread:KDVA]: https://forum.kerbalspaceprogram.com/index.php?/topic/202945-* "Keridian Dynamics Vessel Assembly (KDVA)"
[thread:KGEX]: https://forum.kerbalspaceprogram.com/index.php?/topic/192696-* "KerGuise Experimental Engineering"
[thread:KPLX]: https://forum.kerbalspaceprogram.com/index.php?/topic/202749-* "Komplexity (KMPX)"
[thread:MSRC]: https://forum.kerbalspaceprogram.com/index.php?/topic/204186-* "Mini Sample Return Capsule"
[thread:MSRV]: https://forum.kerbalspaceprogram.com/index.php?/topic/192742-* "Pteron (MSRV)"
[thread:NSSC]: https://forum.kerbalspaceprogram.com/index.php?/topic/191504-* "Not So SimpleConstructon!"
[thread:ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-* "On Demand Fuel Cells"
[thread:QBMF]: https://forum.kerbalspaceprogram.com/index.php?/topic/204753-* "Monero Flags"
[thread:QBTT]: https://forum.kerbalspaceprogram.com/index.php?/topic/204750-* "ISRU Thanks But No Tanks (KBTT)"
[thread:SILP]: https://forum.kerbalspaceprogram.com/index.php?/topic/193051-* "Stock Inline Lights Patches"
[thread:SOLS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192489-* "Solar Science (SOLS)"
[thread:SCON!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-* "SimpleConstructon!"
[thread:SLIF!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191526-* "SimpleLife!"
[thread:SLOG!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045-* "SimpleLogistics!"

<!-- other mods -->
[thread:cc]:  https://forum.kerbalspaceprogram.com/index.php?/topic/91625-* "Contract Configurator"
[thread:mm]:  https://forum.kerbalspaceprogram.com/index.php?/topic/50533-* "Module Manager"
[thread:sr]: https://forum.kerbalspaceprogram.com/index.php?/topic/179306-* "StageRecovery"  
[thread:rt]:  http://remotetechnologiesgroup.github.io/RemoteTech/ "RemoteTech"
[thread:far]: https://forum.kerbalspaceprogram.com/index.php?/topic/179445-* "FAR"  
[thread:kcl]: https://forum.kerbalspaceprogram.com/index.php?/topic/179207-* "Kerbal ChangeLog"
[thread:kct]: https://forum.kerbalspaceprogram.com/index.php?/topic/182877-* "Kerbal Construction Time"  
[thread:kks]: https://forum.kerbalspaceprogram.com/index.php?/topic/133082-* "KRASH"  
[thread:m13]: https://forum.kerbalspaceprogram.com/index.php?/topic/178484-* "Magico13's Modlets"
[thread:tss]: http://forum.kerbalspaceprogram.com/index.php?/topic/154853-* "Tarsier Space Tech"
[thread:twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-* "TweakScale"

<!--- statics -->
[LINK:magico13]:    https://forum.kerbalspaceprogram.com/index.php?/profile/73338-magico13/
[LINK:severedsolo]: https://forum.kerbalspaceprogram.com/index.php?/profile/80345-severedsolo/
[LINK:siriussame]:  https://forum.kerbalspaceprogram.com/index.php?/profile/116426-siriussam/
[LINK:enneract]:    https://forum.kerbalspaceprogram.com/index.php?/profile/56759-enneract/
[LINK:zelda]:       https://forum.kerbalspaceprogram.com/index.php?/profile/66411-zelda/ "Zelda"
[LINK:eightiesboi]: https://forum.kerbalspaceprogram.com/index.php?/profile/133828-eightiesboi/ "eightiesboi" 
[LINK:zer0Kerbal]:  https://forum.kerbalspaceprogram.com/index.php?/profile/190933-zer0kerbal/

<!--- misc logos -->
[IMG:flg:0]: https://via.placeholder.com/256x160png/bada55/111111?text=KGEx "KGEx Flag"
[IMG:hero:0]: https://i.imgur.com/DVDdgU1.png
[IMG:hero:1]: https://i.imgur.com/y0vd6WS.png

<!-- footnotes -->
[^1]: ***may*** work on other versions (YMMV)
[^2]: *Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date!*
[^3]: this isn't a mod. ;P

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-Scrap-BADA55?style=for-the-badge&logo=paypal&labelColor=FFDD00 "PayPal"
[PAYPAL:url]: https://www.paypal.com/donate?hosted_button_id=R9ACWD7VREBCY "PayPal"

[PATREON:img]: https://img.shields.io/badge/Patreon%20-Patreonize-FF424D?style=for-the-badge&logo=patreon "Patreon"
[PATREON:url]: https://www.patreon.com/bePatron?u=23390503 "Patreon"

[GSPONS:img]: https://img.shields.io/badge/Github%20-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors "Github Sponsors"
[GSPONS:url]: https://github.com/sponsors/zer0Kerbal "Github Sponsors"

[BMCC:img]: https://img.shields.io/badge/Buy%20Me%20a%20-Snack!-FFDD00?style=for-the-badge&logo=buymeacoffee "Buy Me A Snack"
[BMCC:url]: https://buymeacoffee.com/zer0Kerbal "Buy Me A Snack"

<!-- Localization -->
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/American-flag-sm.png "American English"
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Brazilian-flag-sm.png "Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Chinese-flag-sm.png "中文"
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/German-flag-sm.png "Deutsch"
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Spanish-flag-sm.png "Español"
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/French-flag-sm.png "Français"
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Italian-flag-sm.png "Italiano"
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Japanese-flag-sm.png "日本語"
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/South-Korean-flag-sm.png "한국어"
[ME]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Mexican-flag-sm.png "Mexicano"
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Dutch-flag-sm.png "Dutch"
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Norwegian-flag-sm.png "Norsk"
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Polish-flag-sm.png "Polski"
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Russian-flag-sm.png "Русский"
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Swedish-flag-sm.png "Svenska"
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Taiwanese-flag-sm.png "国语"
[HA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Hawaii-flag-sm.png "ʻŌlelo Pākē"


<!--
this file: GPLv2 BY
zer0Kerbal-->


<!-- readme.md v1.7.0.0
ScrapYard (SYD)
created: 17 Jul 2017
updated: 01 Jan 2023 -->

<!--this file: CC BY-ND 4.0 by zer0Kerbal-->

[![ScrapYard][MOD:shd:latest]][MOD:forum] [![KSP version][KSP:shd]][KSP:url]  [![License][LIC:shd]][LIC:url]  
[![Curseforge][CURSFG:shd]][CURSFG:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![SpaceDock][SPCDCK:shd]][SPCDCK:url] [![CKAN][CKAN:shd]][CKAN:url]  
[![Pages][MOD:pages:shd]][MOD:pages]

![Code][CODE:shd]

![ScrapYard CC][MOD:CC:shd]

# ScrapYard (SYD)

A common part inventory addon for Kerbal Space Program.


## By [Lisias][lisias] and [zer0Kerbal][zer0Kerbal], originally by [magico13][magico13], then by [severedsolo][severedsolo]

adopted with *express* permission and brought to you by *KerbSimpleCo*

<img src="https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/img/HeroLogo_1920x1920.png" alt="ScrapYard Hero" width="50%" height="50%">

### Preamble by [severedsolo][severedsolo]
>
> So you may have heard that @magico13 is giving up modding KSP. I've got the honour of taking over support for ScrapYard, because it makes sense as I have my own mod that depends on it (Oh Scrap!). I want to take this opportunity to thank magico13 for all his hard work and contributions to the community over the years, as I know that my own KSP experience would be much poorer without his mods. Anyway, enough from me.

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

### See More

>* [ChangeLog][MOD:chlog] for more details of changes
>* [Discussions][MOD:discu] or [KSP Forums][MOD:forum] for discussions and news
>* [GitHub Pages][MOD:pages]
>* [How it Works][MOD:works]
>* [Known Issues][MOD:issue] for more details of feature requests and known issues
>* [Marketing Slicks][MOD:markt]

### Help Wanted

> * Compatibility patches
> * Code improvements through [Github PR][GITHUB:url]
> * Marketing Images and Videos such as hero shots, animated gifs, short highlights
> * Translations: See the [README in the Localization folder][lreadme] for instructions for adding or improving translations. There is also the [quickstart guide][qstart]. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*
> * Have a request? Glad to have them, kindly submit through [GitHub][MOD:issue].

### Localization

>* ![English][EN] English
>* ***your translation here***

### Installation Directions [^1]

***Use***
  CurseForge/OverWolf App (currently does not install dependencies)  

  <a href="https://download.curseforge.com/"> <img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" width="15%" height="15%"></a>

I take no part, nor am I interested in maintaining the [CKAN][ckan:url] mod metadata for my mods. [CKAN][ckan:url] is a great mod for those that can't use zip tools. If you are having issues please let the [CKAN][ckan:url] people know and refer to the [CKAN][ckan:url] thread. My support of [CKAN][ckan:url] extends as far as me checking the checkbox in Spacedock when I upload. Beware, [CKAN][ckan:url] *can* really mess up though it tries very, very, very hard not to.

or [![CKAN][ckan:img]][ckan:url]

### Dependencies

* Either [^3]
  * [Module Manager /L][mml]
  * [Module Manager][mm]
* [Contract Configurator][cc] (only on KSP 1.8.1+)
* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url] [^2]

### Recommends

* [KSP Recall (REC)][rec] *handles issues with Procedural Parts/Fairings/Etc* caused by PP
* [OhScrap! (OHS)][OHS]

### Suggests

* [Adjustable Mod Panel (KAMP)][KAMP]
* [Field Training Facility (FTF)][FTF]
* [Field Training Lab (FTL)][FTL]
* [GPO (Goo Pumps & Oils') Speed Pump (GPO)][GPO]
* [Kaboom! (BOOM)][BOOM]
* [Kerbal Construction Time (KCT)][kct]
* [On Demand Fuel Cells (ODFC)][ODFC]
* [OScience Laboratories (OSL)][OSL]
* [Papa Kerballini's Pizza (PIZZA)][PIZZA]
* [Precise Maneuver (PM)][PM]
* [SimpleConstruction! (SCON)][SCON]
* [SimpleLogistics! (SLOG)][SLOG]
* [SimpleNotes! (NOTE)][NOTES]
* [Solar Science (SOL)][SOL]
* [StageRecovery (SR)][sr]

### Supports

* [Goo Pumps & Oils' (GPO)) Speed Pump (GPOSP)][GPO]
* [On Demand Fuel Cells (ODFC)][ODFC]
* [KRASH][krash]
* [TweakScale (TWK)][twk]
* [RemoteTech (RT)][rt]
* [FAR][far]

#### Mods using ScrapYard (SYD)

* [Kerbal Construction Time][kct] by [@linuxgurugamer][linuxgurugamer] / [@magico13][magico13]
* [Oh Scrap! (OHS)][OHS] by [@severedsolo][severedsolo] / [@zer0Kerbal][zer0Kerbal]

### Tags

plugin,editor,flags,agency,sound,career

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
  <p><b>red box below is a link to forum post on how to get support</b></p>
  <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
    <p><img src="https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a>
  <p style="color: #000000;">Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</p>
</div>

### Credits and Special Thanks

* [`magico13`][magico13] for creating this glorious parts addon!
* [`severedsolo`][severedsolo] for the picking up where [`magico13`][magico13] left off
* [`SiriusSam`][siriussame] for the original idea of creating a separate part inventory way back in 2014 and for the name
* [`enneract`][enneract] for discussion and design help.
* see [Attribution][MOD:attr] for more

### Legal Mumbo Jumbo (License *provenance*)

#### Current (3) - [Lisias][lisias] and [zer0Kerbal][zer0Kerbal]

> Forum: [Thread][MOD:forum] - Source: [GitHub][GITHUB:url]
> License: [![License][LIC:shd]][LIC:url]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***  
> ***All assets, including but not limited to: animations, models, sounds and textures are distributed under their own licenses***

##### see [Notices][MOD:notic] for more *legal Mumbo Jumbo*

#### Author (2) - Author: [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:2:thread] - Download: [CurseForge][MOD:2:dnload] - Source: [GitHub][MOD:2:source]
> License: [![License][LIC:2:shd]][LIC:2:url]

#### Author (1) - Author: [`severedsolo`][severedsolo]

> Forum: [Thread][MOD:1:thread] - Download: [SpaceDock][MOD:1:dnload] - Source: [GitHub][MOD:1:source]
> License: [![License][LIC:1:shd]][LIC:1:url]

#### Original (0) - Author: [`magico13`][magico13]

> Forum: [Thread][MOD:0:thread] - Download: [SpaceDock][MOD:0:dnload] - Source: [GitHub][MOD:0:source]
> License: [![License][LIC:0:shd]][LIC:0:url]

<!-- mod links -->
[MOD:attr]: https://zer0kerbal.github.io/ScrapYard/Attributions "Attribution"
[MOD:chlog]: https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/changelog.md "Changelog"
[MOD:discu]: https://github.com/zer0Kerbal/ScrapYard/discussions "Discussions"
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/192456-*/ "ScrapYard (SYD)Forum Thread"
[MOD:issue]: https://github.com/zer0Kerbal/ScrapYard/issues "Issues"
[MOD:markt]: https://zer0kerbal.github.io/ScrapYard/Marketing "Marketing Slicks"
[MOD:notic]: https://zer0kerbal.github.io/ScrapYard/Notices "Notices"
[MOD:pages]: https://zer0kerbal.github.io/ScrapYard "GitHub Pages"
[MOD:works]: https://zer0kerbal.github.io/ScrapYard/HowItWorks "How It Works"

<!--- mod -->
[MOD:shd:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/mod.json

[MOD:CC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/sycc.json

[CODE:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/code.json

[MOD:pages:shd]: https://img.shields.io/badge/GitHub-Pages-white?style=plastic&labelColor=9cf&logoColor=181717&logo=github "GitHub IO"

<!--- mod provenance -->
[MOD:2:dnload]: https://www.curseforge.com/kerbal/ksp-mods/scrapyard "CurseForge"
[MOD:2:source]: https://github.com/zer0Kerbal/ScrapYard "GitHub"
[MOD:2:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/192456-*/ "KSP Forum"

[MOD:1:dnload]: http://spacedock.info/mod/1746 "SpaceDock"
[MOD:1:source]: https://github.com/severedsolo/ScrapYard "GitHub"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/178641-*/ "KSP Forum"

[MOD:0:dnload]: http://spacedock.info/mod/1746 "SpaceDock"
[MOD:0:source]: https://github.com/magico13/ScrapYard "GitHub"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/160257-*/ "KSP Forum"

<!--- license provenance -->
[LIC:2:url]: https://opensource.org/licenses/MIT "Expat-MIT"
[LIC:2:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:1:url]: https://opensource.org/licenses/MIT "Expat-MIT"
[LIC:1:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:0:url]: https://opensource.org/licenses/MIT "Expat-MIT"
[LIC:0:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=black&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:url]: https://www.gnu.org/licenses/gpl-2.0-standalone.html "GPL-2.0"
[LIC:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/license.json

<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png "CKAN"
[CKAN:url]: http://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/ "CKAN"
[CKAN:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/ckan.json "CKAN"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/ScrapYard "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/ScrapYard/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=071776&style=plastic&logo=github "GitHub"

[SPCDCK:url]: http://spacedock.info/mod/1746 "SpaceDock"
[SPCDCK:shd]:  https://img.shields.io/badge/SpaceDock-Link-CCFF00.svg?labelColor=000000&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/ScrapYard/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"

<!-- links to add-ons/mods -->
[BOOM]: https://forum.kerbalspaceprogram.com/index.php?/topic/192938-*/ "Kaboom! (BOOM)"
[FTF]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-*/ "Field Training Facility (FTF)"
[FTL]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-*/ "Field Training Lab (FTL)"
[GPO]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPO SpeedPump (GPO)"
[KAMP]: https://forum.kerbalspaceprogram.com/index.php?/topic/207263-*/ "Adjustable Mode Panel (KAMP)"
[NOTES]: https://forum.kerbalspaceprogram.com/index.php?/topic/207118-*/ "SimpleNotes! (NOTES) (NOTES)"
[ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "On Demand Fuel Cells (ODFC)"
[OHS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-*/ "OhScrap (OHS)"
[OSL]: https://forum.kerbalspaceprogram.com/index.php?/topic/209490-*/ "OScience Laboratories (OSL)"
[PIZZA]: https://forum.kerbalspaceprogram.com/index.php?/topic/209577-*/ "Papa Kerballini's Pizza (PIZZA)"
[PM]: https://forum.kerbalspaceprogram.com/index.php?/topic/207261-*/ "Precise Maneuver (PM)"
[SCON]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-*/ "SimpleConstruction! (SCON)"
[SLOG]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045-*/ "SimpleLogistics! (SLOG)"
[SOL]: https://forum.kerbalspaceprogram.com/index.php?/topic/192489-*/ "Solar Science (SOL)"
Facility (FTF)"

[cc]: https://forum.kerbalspaceprogram.com/index.php?/topic/91625-*/ "Contract Configurator"
[far]: https://forum.kerbalspaceprogram.com/index.php?/topic/179445-*/ "FAR"
[kct]: https://forum.kerbalspaceprogram.com/index.php?/topic/182877-*/ "Kerbal Construction Time"
[krash]: http://forum.kerbalspaceprogram.com/index.php?/topic/133082-*/ "KRASH"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
[rec]: https://forum.kerbalspaceprogram.com/index.php?/topic/192048-*/ "KSP Recall (REC)"
[rt]:  http://remotetechnologiesgroup.github.io/RemoteTech/ "RemoteTech"
[sr]: https://forum.kerbalspaceprogram.com/index.php?/topic/179306-*/ "Stage Recovery"
[twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/ "TweakScale"

<!-- Localization -->
[lreadme]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/readme.md "Localization Readme"
[qstart]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/quickstart.md "Quickstart"
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/EN.png "English"  
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/BR.png "Português Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/CH.png "中文"  
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/DE.png "Deutsch"  
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/ES.png "Español"  
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/FR.png "Français"  
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/IT.png "Italiano"  
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/JA.png "日本語"  
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/KO.png "한국어"  
[MX]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/MX.png "Mexicano Español"  
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NL.png "Dutch"  
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NO.png "Norsk"
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/PO.png "Polski"  
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/RU.png "Русский"  
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/SW.png "Svenska"  
[TR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TR.png "Türk"  
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TW.png "国语"

[enneract]: https://forum.kerbalspaceprogram.com/index.php?/profile/56759-*/ "enneract"
[linuxgurugamer]: https://forum.kerbalspaceprogram.com/index.php?/profile/129964-*/ "linuxgurugamer"
[magico13]: https://forum.kerbalspaceprogram.com/index.php?/profile/73338-*/ "magico13"
[severedsolo]: https://forum.kerbalspaceprogram.com/index.php?/profile/80345-*/ "severedsolo"
[siriussame]: https://forum.kerbalspaceprogram.com/index.php?/profile/116426-*/ "siriussam"

[lisias]: https://forum.kerbalspaceprogram.com/index.php?/profile/187168-*/ "Lisias"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"

---

#### Connect with me

Track progress: issues [here][MOD:issue] and projects [here](https://github.com/zer0Kerbal/ScrapYard/projects/) along with **[The Short List](https://github.com/users/zer0Kerbal/projects/27)**

[<img align="left" alt="zer0Kerbal | kerbalspaceprogram.com" width="32px" src="https://cdn.icon-icons.com/icons2/1381/PNG/32/kerbalspaceprogram_93898.png" />][zer0Kerbal] [<img align="left" alt="zer0Kerbal | CurseForge" width="32px" src="https://cdn.jsdelivr.net/npm/simple-icons@v3/icons/curseforge.svg" />][curseforge] [<img align="left" alt="zer0Kerbal | reddit" width="32px" src="https://cdn.icon-icons.com/icons2/1945/PNG/512/iconfinder-reddit-4661631_122483.png" />][reddit] [<img align="left" alt="zer0Kerbal | Patreon" width="32px" src="https://cdn.icon-icons.com/icons2/2429/PNG/512/patreon_logo_icon_147253.png" />][PATREON:url] [<img align="left" alt="zer0Kerbal | YouTube" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/512/Youtube_icon-icons.com_66802.png" />][youtube] [<img align="left" alt="zer0Kerbal | Twitch" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/twitch_logo_icon_170383.png" />][twitch] [<img align="left" alt="zer0Kerbal | PayPal" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/paypal_logo_icon_168055.png" />][PAYPAL:url] [<img align="left" alt="zer0Kerbal | Buy Me a Coffee" width="32px" src="https://www.buymeacoffee.com/assets/img/bmc-meta-new/new/favicon.ico" />][BMCC:url] [<img align="left" alt="zer0Kerbal | Twitter" width="32px" src="https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/twitter-32.ico" />][twitter]</br>

##### Release Schedule

1. GitHub, reaching first manual installers and users of KSP-AVC. Right now.
2. CurseForge. Right now.
3. SpaceDock (and CKAN users). Soon™ *(the button was pressed)*

<!-- footnotes -->
[^1]: this isn't a mod. ;P  
[^2]: ***may*** work on other versions (YMMV)  
[^3]: *Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date!*
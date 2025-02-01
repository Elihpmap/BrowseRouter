# Changelog

All notable changes to this project should be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project (now) adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).



## Unreleased (will be [0.15.0])

### Added
- Changelog File to follow the project evolution and compatibility changes.
- Version number at the start of the config file to be able to test for compatibility issues and warn the user if any are found.

### Changed
- The "Source" comparison strings are now also containig the calling process name in addition to the main window title of the calling program (if it has any).
- The name of the config file is now `BrowseRouterConfig.ini` and not `config.ini` anymore.

### Fixed
- Wrong "Source" found when the process opening the link is not currently in the foreground or has no window title.



## [0.14.0] - 2025-01-05

### Added 
- Possibility to mute Windows notifications sound generated when opening a link: [issue 69](https://github.com/nref/BrowseRouter/issues/69)
- More replacement tags possibilities in the browser launch commands (working similarly to the `{url}` one). Now available tags are: `{url}`, `{userinfo}`, `{host}`, `{port}`, `{authority}`, `{path}`, `{query}` and `{fragment}`, corresponding to their respective [name of the differents parts of the URI](https://en.wikipedia.org/wiki/Uniform_Resource_Identifier#Example_URIs)

### Fixed
- Fixed the help text not being displayed when launching from the command line: [issue 72](https://github.com/nref/BrowseRouter/issues/72)
- `{url}` replacement tag not working anymore in the browser launch command: [issue 10](https://github.com/nref/BrowseRouter/issues/10)



## [0.13.2] - 2024-12-10

### Fixed
- Correction of implementation for the bug fix in [0.13.1]


## [0.13.1] - 2024-12-07

### Fixed
- Issue causing other aplications to fail launching the app correctly when the path contained spaces: [issue 63](https://github.com/nref/BrowseRouter/issues/63)



## [0.13.0] - 2024-12-07

### Added
- Ability to expand environment variables in the browser path [PR 62](https://github.com/nref/BrowseRouter/pull/62)

### Fixed 
- 10 seconds delay when opening an URL with notification enabled: [issue 58](https://github.com/nref/BrowseRouter/issues/58)


## [0.12.6] - 2024-11-27
`incomplete changelog`



## [0.12.5] - 2024-11-20
`incomplete changelog`



## [0.12.4] - 2024-11-04
`incomplete changelog`



## [0.12.2] - 2024-10-31
`incomplete changelog`



## [0.12.1] - 2024-10-28
`incomplete changelog`



## [0.11.0] - 2024-10-28
`incomplete changelog`

### Changed
- Switch the project version number to Semantic Versionning 



## [0.8.0.0] - 2024-09-20
`incomplete changelog`



## [0.7.2.0] - 2024-08-31
`incomplete changelog`



## [0.7.1.0] - 2024-08-30
`incomplete changelog`



## [0.7.0.0] - 2024-08-29
`incomplete changelog`



## [0.6.0.0] - 2023-04-07
`incomplete changelog`



## [0.5.0.0] - 2023-04-07
`incomplete changelog`



## [0.4.0.0] - 2022-07-07
`incomplete changelog`



## [0.3.0.0] - 2016-02-22
`incomplete changelog`



## [0.2.0.0] - 2015-09-22
`incomplete changelog`



## [0.1.0.0] - 2015-09-20
`incomplete changelog`

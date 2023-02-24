# Unity Smart Importer
Allows import Unity packages (.unitypackage) to custom folder, ignoring initial assets paths.

[![NPM Package](https://img.shields.io/npm/v/com.dreamcode.editor.smart-importer)](https://www.npmjs.com/package/com.dreamcode.editor.smart-importer)
[![Licence](https://img.shields.io/npm/l/com.dreamcode.mobile.android-keystore)](https://github.com/dreamcodestudio/com.dreamcode.editor.smart-importer/blob/main/LICENSE)

### Install from npm 🤖
* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file](https://docs.unity3d.com/Manual/upm-manifestPrj.html) `manifest.json` in a text editor and add `com.dreamcode` is part of scopes.
```json
  {
    "scopedRegistries": [
      {
        "name": "npmjs",
        "url": "https://registry.npmjs.org/",
        "scopes": [
          "com.dreamcode"
        ]
      }
    ],
    "dependencies": {
      ...
    }
  }
```

* Open `Package Manager` and press `Install` button.

<img src="https://user-images.githubusercontent.com/7010398/221207311-81e95b1e-8ea4-4530-82bd-9409f19b878b.png" width="730">

* Open the menu item `Import Package > Extract Here`

https://user-images.githubusercontent.com/7010398/221209668-6680d81d-01b9-4071-9a5c-06f8d13e267a.mp4

### Well done 🤝
Now you can import .unitypackage to custom folder.

### Unity Editors Support
`Smart Importer` implemented via C# Reflection  and pass tests on the editor versions

`2020`, `2021`, `2022`

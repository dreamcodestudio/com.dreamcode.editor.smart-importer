# Unity Smart Importer
Allows import Unity packages (.unitypackage) to custom folder, ignoring initial assets paths.

[![NPM Package](https://img.shields.io/npm/v/com.dreamcode.editor.smart-importer)](https://www.npmjs.com/package/com.dreamcode.editor.smart-importer)
[![openupm](https://img.shields.io/npm/v/com.dreamcode.editor.smart-importer?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.dreamcode.editor.smart-importer/)
[![Licence](https://img.shields.io/npm/l/com.dreamcode.mobile.android-keystore)](https://github.com/dreamcodestudio/com.dreamcode.editor.smart-importer/blob/main/LICENSE)
![NPM Downloads](https://img.shields.io/npm/dt/com.dreamcode.editor.smart-importer)

# How do I install Smart Importer?

<details>
<summary>Install via OpenUPM cli</summary>

```
openupm add com.dreamcode.editor.smart-importer
```
</details>

<details>
<summary>Install from git URL via Package Manager</summary>

1. Open the menu item `Window > Package Manager`
1. Click `+` button and select `Add package from git URL...`
1. Enter the following URL and click `Add` button

```
https://github.com/dreamcodestudio/com.dreamcode.editor.smart-importer.git
```
</details>

<details>
<summary>Install via npm</summary>

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

</details>

<details>
<summary>Install via Asset Store</summary>
https://assetstore.unity.com/packages/slug/254217
</details>

# How do I use Smart Importer?

* Open the menu item `Import Package > Extract Here`

https://github.com/user-attachments/assets/054dda19-1ca5-4852-a540-2c648bf874cf



### Well done 🤝
Now you can import .unitypackage to custom folder.

### Unity Editors Support
`Smart Importer` implemented via C# Reflection  and pass tests on the editor versions

`2020`, `2021`, `2022`

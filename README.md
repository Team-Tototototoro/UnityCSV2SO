# UnityCSV2SO
**Requires Odin Inspector**

![Data population example](/DataPopulation.gif)

## Painlessly convert CSV data into easy-to-use ScriptableObjects.
Scriptable Objects can be passed around easily in Editor. The only real downfall they have is their serialization can get dangerous when they are updated frequently. Using CSV's is a standard and safe way to keep a master copy of your data while also allowing it to be fed into the game engine quickly.

## Instructions
1. Copy the folder into your Unity project.
1. Make a new class for a piece of grouped data you want in a SO that should read from a CSV.
    * Make sure it inherits from *CSVPopulableScriptableObject*.
    * This data should be **immutable**, meaning it should not be data that changes during runtime.
    * Use the *SampleCSVPopulableScriptableObject.cs* file as a template example for how to write a *CSVPopulableScriptableObject*.
1. Export a .csv from your editor of choice (probably either Excel or Google sheets)
1. Make sure that your class key matches the first element of the .csv row.
1. Click on the radial menu to load the appropriate .csv, click the 'Populate' button, and profit.
    * Refer to the gif to see this in action.
    
## FAQ
1. *Doesn't this introduce a lot of boilerplate?*
    * No, because by using build tags (*IF UNITY_EDITOR* and the like) all of this csv reading stuff is eliminated from the final build. All you need to do is make the data up-to-date before building.
2. *Can I use this without Odin Inspector?*
    * Yes, but you will need to write your own custom inspector using built-in Unity. I couldn't be bothered to do that, and honestly, after Odin cut my tooling times in 10, neither should you. Just get it, it goes on sale often.

## Credits
Sheehan Ahmed, Kevin Lin, Bethany Lai, Daniel Ochoa, Carys Gooi - USC IMGD students

## License
This has been made public under the MIT license.
Feel free to use this code in your own projects. Credit is appreciated but not necessary.
Please **DO NOT** try to sell this asset, or redistribute elsewhere as your own work.

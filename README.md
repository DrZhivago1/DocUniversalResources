# DocUniversalResources
DUR catches duplicate resources and replaces them with one defName. This happens behind the scenes and Users will "hopefully" not notice. Duplicate items across all supported mods will be usable across all installed mods where they normally would be. This allows increased effectiveness in patching, as well as apply patches to a wider variety of mods. The goal of this change is to supply mod makers/users an enhanced game-play experience, with fewer conflicts, and more cross-compatibility.

Example: You had 3 types of coal. Now 1 type. If any mod author allows one type of supported coal to be used in their mod, they get patched into the entire database of supported coal mods. Mod author no longer needs to patch for every coal type. Now use this example for every supported resource type.

This mod needs to load below all supported content mods, and all mods that patch supported content. Easiest to simply load last/low in load list.
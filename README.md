# Steam Wishlist JSON to Markdown Blazor

This project is an application that converts Steam wishlist data from JSON format to Markdown. It uses the Blazor framework and the Windows Forms WebView package for the user interface. The final Markdown file includes general information about the wishlist, such as the number of games, average price, and total price, as well as a list of each game in the wishlist with details like title, price, GameID, and URL.

## Introduction

Have you ever wanted to share your Steam wishlist with someone who doesn't have a Steam account, doesn't want to use the Steam website or because of anything else? Then this project is for you! It converts the JSON file of your Steam wishlist, obtained using Augmented Steam, to a well-structured Markdown file that you can easily edit and/or share with others. The Markdown file includes general information about the wishlist, such as the number of games, average price, and total price, as well as a list of each game in the wishlist with details like title, price, discount (if available), GameID, and URL.

## Features

- Converts Steam wishlist data from JSON to Markdown.
- Provides general information about the wishlist, such as the number of games, average price, and total price (not counting free or not released games and hardware).
- Lists each game in the wishlist with details like title, price, GameID, and URL.
- Formats prices in Euros (€).
- Generates a well-structured Markdown file ready for sharing or further editing.

## Usage

### Building from source

1. Clone or download the repository.
2. Open the solution file `SteamWishlistJSONToMarkdownBlazor.sln` in Visual Studio.
3. Download the JSON file of your Steam wishlist from the Steam website using [Augmented Steam](https://github.com/IsThereAnyDeal/AugmentedSteam).
4. Build and run the project.
5. Now you are ready to convert your Steam wishlist data to Markdown.

### Installing from release/prebuilt binaries

1. Download the latest release from the [Releases](https://github.com/KylerianHD/Steam-Wishlist-To-Markdown-Converter/releases/latest) page.
2. Extract the files wherever you want. (**ATTENTION**: All files within the archive must be in the same directory, due to the nature of Blazor Hybrid applications.)
4. Go to the [Steam website](https://store.steampowered.com/wishlist) and download the JSON file of your Steam wishlist using [Augmented Steam](https://github.com/IsThereAnyDeal/AugmentedSteam).
5. Start the application (`SteamWishlistToMarkdownConverter.exe`).
6. Now you are ready to convert your Steam wishlist data to Markdown.

## Future Goals

- [X] Beautify the user interface.
- [ ] Make price formatting work with all countries and their currencies.
- [ ] Being able to get the JSON file of the Steam wishlist without the user having to use Augmented Steam.
- [ ] Enable the user to directly convert the markdown to a PDF file.

## Known Issues

- The application currently only works with the currency Euro (€).

If you encounter any bugs or issues, please report them on the [Issues](https://github.com/KylerianHD/Steam-Wishlist-To-Markdown-Converter/issues) page.

## Thanks

- [IsThereAnyDeal](https://isthereanydeal.com/) for their awesome extension [Augmented Steam](https://github.com/IsThereAnyDeal/AugmentedSteam).
- [JamesNK](https://github.com/JamesNK) for their awesome JSON library [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json).
- Also a special thanks to my friend for the initial idea and the motivation to create this project.
- And thanks to you for using, staring, contributing or even just having a look at this project! 

## Information for Contributors

### Classes

- `SteamData`: Represents the entire Steam wishlist data structure
- `SteamEntry`: Represents every or an individual entry in the Steam wishlist

### Dependencies

All dependencies are included in the project and should be automatically restored by Visual Studio. If not or if you are using a different IDE, you can manually install the following NuGet packages:
- [Microsoft.AspNetCore.Components.WebView.WindowsForms](https://www.nuget.org/packages/Microsoft.AspNetCore.Components.WebView.WindowsForms/)
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json)

## License

This project is licensed under the GNU General Public License Version 3. The full license can be found in the `LICENSE.txt`.

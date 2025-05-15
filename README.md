# PgbNameCase

PgbNameCase is a .NET library for properly casing personal names, handling a wide variety of edge cases such as particles (e.g., "van", "de"), prefixes (e.g., "Mc", "Mac"), apostrophes, Roman numerals, and more. It is designed to convert names from any capitalization to their correct, human-readable form.

## Features

- Correctly capitalizes names with prefixes like "Mc", "Mac", "O'", etc.
- Handles names with particles (e.g., "van", "de", "von", "bin", "al").
- Supports names with apostrophes and hyphens.
- Recognizes and formats Roman numerals.
- Handles special cases and exceptions for common names.
- Null-safe and culture-invariant.

## Installation

Install from NuGet:

```sh
dotnet add package PgbNameCase
```

## Usage

```csharp
using PgbNameCase;

string formatted = NameCaseFormatter.Format("john mccarthy"); // "John McCarthy"
string formatted2 = NameCaseFormatter.Format("leonardo da vinci"); // "Leonardo da Vinci"
string formatted3 = NameCaseFormatter.Format("o'connor"); // "O'Connor"
string formatted4 = NameCaseFormatter.Format("charles iii"); // "Charles III"
```

If you need to use custom formatted names, you can pass your own set:

```csharp
var customNames = new HashSet<string> { "McCloud", "MacLeod" };
string formatted = NameCaseFormatter.Format("john mccloud", customNames); // "John McCloud"
```

## API

- [`NameCaseFormatter.Format`](src/NameCase/NameCase/NameCaseFormatter.cs): Main entry point for formatting names.
- [`FormattedNameFactory.GetNames`](src/NameCase/NameCase/FormattedNameFactory.cs): Provides the default set of special-case names.
- [`SpecialHandlingFactory`](src/NameCase/NameCase/SpecialHandlingFactory.cs): Contains lists of particles, prefixes, and two-letter names.

## Testing

Unit tests are provided in the [src/NameCase/UnitTests](src/NameCase/UnitTests) directory. To run the tests:

```sh
dotnet test
```

## License

MIT License. See [LICENSE.txt](LICENSE.txt).

&copy; Paul G Brown. All rights reserved.

## Acknowledgements

Thanks to [tamtamchik/namecase](https://github.com/tamtamchik/namecase) for inspiration and test cases.


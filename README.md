# UNSW Handbook API

DotNet API for the UNSW course handbook.

## Usage

The primary entry point of the API is the `UNSWHandbookAPI` class. Here is an example of using the API for subject information:

```
Subject subject = await UNSWHandbookAPI.GetSubject("math2621", UNSWHandbookAPI.StudyLevel.Undergraduate);
Console.WriteLine(subject);
```

The `Subject` class has an override for `ToString()` so that it can be displayed to the console directly as above. The above code sample displays the following:

```
MATH2621 - Higher Complex Analysis
Faculty of Science
Units of Credit: 6
Exclusions:
- MATH2520 - Complex Analysis
- MATH2521 - Complex Analysis
- MATH2620 - Higher Complex Analysis
Offering Terms:
- Term 3
Conditions of Enrolment:
- Prerequisite: MATH1231 or DPST1014 or MATH1241 or MATH1251 each with a mark of at least 70; Exclusion: MATH2069
```

Similarly the `UNSWHandbookAPI.GetProgram()` method returns an instance of the `Program` class, similar to the above.

The desired handbook page year can be specified as an optional third parameter. When left blank, this will default to the current year.

## Notes

Since the way this API connects to the UNSW handbook is not officially supported, it is very possible that over time, as the website changes, aspects of this API will break. While I make no promises to regularly maintain it, if you find this tool valuable but encounter a bug of some kind, an issue on this repository would be greatly appreciated.

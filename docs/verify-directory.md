<!--
GENERATED FILE - DO NOT EDIT
This file was generated by [MarkdownSnippets](https://github.com/SimonCropp/MarkdownSnippets).
Source File: /docs/mdsource/verify-directory.source.md
To change this file edit the source file and then run MarkdownSnippets.
-->

# VerifyDirectory

Verifies all files in a directory. This approach combines [UseUniqueDirectory](/docs/naming.md#useuniquedirectory) with a target per file, to snapshot test all files in a directory.

<!-- snippet: VerifyDirectoryXunit -->
<a id='snippet-verifydirectoryxunit'></a>
```cs
[Fact]
public Task WithDirectory() =>
    VerifyDirectory(directoryToVerify);
```
<sup><a href='/src/Verify.Xunit.Tests/Tests.cs#L83-L89' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifydirectoryxunit' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Filtering

<!-- snippet: VerifyDirectoryFilterXunit -->
<a id='snippet-verifydirectoryfilterxunit'></a>
```cs
[Fact]
public Task WithDirectoryFiltered() =>
    VerifyDirectory(
        directoryToVerify,
        include: filePath => filePath.Contains("Doc"),
        pattern: "*.txt",
        options: new()
        {
            RecurseSubdirectories = false
        });
```
<sup><a href='/src/Verify.Xunit.Tests/Tests.cs#L103-L116' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifydirectoryfilterxunit' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->


## Optional Info

An optional `info` parameter can be supplied to add more context to the test. The instance passed will be json serialized.

<!-- snippet: VerifyDirectoryWithInfo -->
<a id='snippet-verifydirectorywithinfo'></a>
```cs
[Fact]
public Task VerifyDirectoryWithInfo() =>
    VerifyDirectory(
        directoryToVerify,
        info: "the info");
```
<sup><a href='/src/Verify.Xunit.Tests/Tests.cs#L91-L99' title='Snippet source file'>snippet source</a> | <a href='#snippet-verifydirectorywithinfo' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

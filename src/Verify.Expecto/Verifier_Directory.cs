﻿// ReSharper disable RedundantSuppressNullableWarningExpression

namespace VerifyExpecto;

public static partial class Verifier
{
#if NETSTANDARD2_1 || NETCOREAPP3_0_OR_GREATER || NET5_0_OR_GREATER

    /// <summary>
    /// Verifies the contents of <param name="path"/>.
    /// </summary>
    public static Task<VerifyResult> VerifyDirectory(
        string name,
        string path,
        Func<string, bool>? include = null,
        string? pattern = null,
        EnumerationOptions? options = null,
        VerifySettings? settings = null,
        object? info = null,
        [CallerFilePath] string sourceFile = "")
    {
        var assembly = Assembly.GetCallingAssembly()!;
        return Verify(settings, assembly, sourceFile, name, _ => _.VerifyDirectory(path, include, pattern, options, info), true);
    }

    /// <summary>
    /// Verifies the contents of <param name="path"/>.
    /// Differs from passing <see cref="DirectoryInfo"/> to <code>Verify(object target)</code> which will verify the full path.
    /// </summary>
    public static Task<VerifyResult> VerifyDirectory(
        string name,
        DirectoryInfo path,
        Func<string, bool>? include = null,
        string? pattern = null,
        EnumerationOptions? options = null,
        VerifySettings? settings = null,
        object? info = null,
        [CallerFilePath] string sourceFile = "") =>
        VerifyDirectory(name, path.FullName, include, pattern, options, settings, sourceFile);

#else

    /// <summary>
    /// Verifies the contents of <param name="path"/>.
    /// </summary>
    public static Task<VerifyResult> VerifyDirectory(
        string name,
        string path,
        Func<string, bool>? include = null,
        string? pattern = null,
        SearchOption option = SearchOption.AllDirectories,
        VerifySettings? settings = null,
        object? info = null,
        [CallerFilePath] string sourceFile = "")
    {
        var assembly = Assembly.GetCallingAssembly()!;
        return Verify(settings, assembly, sourceFile, name, _ => _.VerifyDirectory(path, include, pattern, option, info), true);
    }

    /// <summary>
    /// Verifies the contents of <param name="path"/>.
    /// Differs from passing <see cref="DirectoryInfo"/> to <code>Verify(object target)</code> which will verify the full path.
    /// </summary>
    public static Task<VerifyResult> VerifyDirectory(
        string name,
        DirectoryInfo path,
        Func<string, bool>? include = null,
        string? pattern = null,
        SearchOption option = SearchOption.AllDirectories,
        VerifySettings? settings = null,
        object? info = null,
        [CallerFilePath] string sourceFile = "") =>
        VerifyDirectory(name, path.FullName, include, pattern, option, settings, sourceFile);

#endif

}
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "ICSharpCode.SharpZipLib.Zip.MemoryArchiveStorage")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.ZipFile+PartialInputStream.#Read(System.Byte[],System.Int32,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.ZipFile+PartialInputStream.#ReadByte()")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.ZipFile.#DisposeInternal(System.Boolean)")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2002:DoNotLockOnObjectsWithWeakIdentity", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.ZipFile.#TestLocalHeader(ICSharpCode.SharpZipLib.Zip.ZipEntry,ICSharpCode.SharpZipLib.Zip.ZipFile+HeaderTest)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.NTTaggedData.#GetData()")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.NTTaggedData.#SetData(System.Byte[],System.Int32,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.#SetData(System.Byte[],System.Int32,System.Int32)")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "_hmacsha1", Scope = "member", Target = "ICSharpCode.SharpZipLib.Encryption.ZipAESTransform.#Dispose()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1065:DoNotRaiseExceptionsInUnexpectedLocations", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.Compression.InflaterHuffmanTree.#.cctor()")]
[assembly: SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times", Scope = "member", Target = "ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.#GetData()")]
[assembly: SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "ICSharpCode.SharpZipLib.Zip.DiskArchiveStorage")]

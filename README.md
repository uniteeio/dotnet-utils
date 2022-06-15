# Unitee utils

Various of methods, tools and extensions used commonly in Unitee.

## Fluent blob storage

Fluent API for Azure Blob Storage manipulation.

```cs
// Setup
var storage = new FluentBlobStorage()
    .WithConnectionString("xxxxxx")
    .WithContainerName("documents");

// Upload a stream
using var fileStream = new FileStream(@"/app/file.txt", FileMode.Open);

var (uri, response) = await storage
    .WithFileName("file.txt")
    .WithContentType("text/plain")
    .UploadAsync(filestream);

// Upload IFormFile
var formFile = req.File;

var (uri, response) = await storage
    .WithFileName("file.txt")
    .WithContentType("text/plain")
    .UploadAsync(formFile);

// Download
var (stream, blobProperties) = storage
    .WithFileName("file.txt")
    .OpenRead();

var contentType = blobProperties.ContentType;
return File(stream, contentType);

```

### Extensions Methods

- [String Extensions](./docs/StringExtensions.md)
- [Datetime Extensions](./docs/DatetimeExtensions.md)
- [Enums Extensions](./docs/EnumsExtensions.md)






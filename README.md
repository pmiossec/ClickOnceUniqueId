## Introduction

This program provide a unique number (based on the date and time) to use for `ApplicationRevision` when using ClickOnce deployment.

It could also update itself the csproj file if you pass it as parameter.

## Use

### Without parameters

    ClickOnceUniqueId.exe
   
will return:

    315993

### With a csproj path as parameter

    ClickOnceUniqueId.exe C:\Path\To\My\Project.csproj

will update the `ApplicationRevision` variable in the `Project.csproj` file.

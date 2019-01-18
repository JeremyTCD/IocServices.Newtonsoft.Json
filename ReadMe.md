# Jering.IocServices.Newtonsoft.Json
[![Build Status](https://dev.azure.com/JeremyTCD/IocServices.Newtonsoft.Json/_apis/build/status/IocServices.Newtonsoft.Json-CI?branchName=master)](https://dev.azure.com/JeremyTCD/IocServices.Newtonsoft.Json/_build/latest?definitionId=10?branchName=master)
[![License](https://img.shields.io/badge/license-Apache%202.0-blue.svg)](https://github.com/Pkcs11Interop/Pkcs11Interop/blob/master/LICENSE.md)
[![NuGet](https://img.shields.io/nuget/vpre/Jering.IocServices.Newtonsoft.Json.svg?label=nuget)](https://www.nuget.org/packages/Jering.IocServices.Newtonsoft.Json/)

## Table of Contents
[Overview](#overview)  
[Target Frameworks](#target-frameworks)  
[Installation](#installation)  
[Usage](#usage)  

## Overview
This is a generated library that provides inversion of control services for types in the `Newtonsoft.Json` namespace. **This library and its generator are both incomplete and under construction.**

## Target Frameworks
- .NET Standard 1.3
 
## Installation
Using Package Manager:
```
PM> Install-Package Jering.IocServices.Newtonsoft.Json
```
Using .Net CLI:
```
> dotnet add package Jering.IocServices.Newtonsoft.Json
```

## Usage
```csharp
var services = new ServiceCollection();
services.AddSingleton<IJsonSerializerService, JsonSerializerService>();
ServiceProvider serviceProvider = services.BuildServiceProvider();
IJsonSerializerService jsonSerializerService = serviceProvider.GetRequiredService<IJsonSerializerService>();
```
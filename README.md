Welcome
=======

Learn more about best practices for implementing dependency injection in .NET applications. [pt-br](https://docs.microsoft.com/pt-br/dotnet/core/extensions/dependency-injection-guidelines) / [en-us](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection-guidelines).

### 𝐀𝐝𝐝𝐒𝐢𝐧𝐠𝐥𝐞𝐭𝐨𝐧 vs 𝐀𝐝𝐝𝐒𝐜𝐨𝐩𝐞𝐝 vs 𝐀𝐝𝐝𝐓𝐫𝐚𝐧𝐬𝐢𝐞𝐧𝐭

Whenever we ask for the service, the **DI Container** has to decide whether to return a new instance of the service or provide an existing instance. The Lifetime of the Service depends on how we instantiate the dependency. We define the lifetime when we register the service.

The below three methods define the lifetime of the services:  
  
• 𝐀𝐝𝐝𝐒𝐢𝐧𝐠𝐥𝐞𝐭𝐨𝐧 - Singleton lifetime services are created the first time they are requested (or when ConfigureServices is run if you specify an instance there) and then every subsequent request will use the same instance.  
`builder.Services.AddSingleton();`

• 𝐀𝐝𝐝𝐒𝐜𝐨𝐩𝐞𝐝 - Scoped lifetime services are created once per request.  
`builder.Services.AddScoped();`

• 𝐀𝐝𝐝𝐓𝐫𝐚𝐧𝐬𝐢𝐞𝐧𝐭 - Transient lifetime services are created each time they are requested. This lifetime works best for lightweight, stateless services.  
`builder.Services.AddTransient();`

|      Type      |    Same request    |  Different requests  |
|----------------|--------------------|----------------------|
|  Singleton     |   Same instance    |   Same instance      |
|  Scoped        |   Same instance    |   New instance       |
|  Transient     |   New instance     |   New instance       |

The lifecycle impact is that with the exception of Singleton, **Scoped and Transient** are **impacted** by the number of **requests.**

𝐖𝐡𝐢𝐜𝐡 𝐨𝐧𝐞 𝐭𝐨 𝐮𝐬𝐞?  
  
Use Transient lifetime for the lightweight service with little or no state.  
Scoped services service is the better option when you want to maintain state within a request.  
Use Singletons where you need to maintain application wide state. Application configuration or parameters, Logging Service, caching of data is some of the examples where you can use singletons.

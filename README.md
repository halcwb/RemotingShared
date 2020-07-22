# RemotingShared

This is a lab project that explores a problem I have with Fable.Remoting. The concept is that you can share types between the client and server and expose a very neat remoting api
using those types. The caveat is that this works really well when only using a shared code file without any dependencies on external projects that cannot run on the client.
For example an IO action.

If you want to expose types from an external library, called Shared.Lib in this example, you'l need to create a Shared project file that contains the Shared code file.
This project file has to be referenced by the server and the client. Just the sharing the code file with the client won't work in this case. The problem is that not only the types
are shared with the client but also code that won't compile on the client side.

In the final commit the problem is solved by copying over the 'external' counter type to the 'shared' counter type. So:

1. The client references a shared code file that contains the shared counter type
2. The server references the shared code file
3. The server also references a Counter.Lib which retrieves a counter type by reading a file
4. The server maps the Counter.Lib counter type to the shared counter type

The counter type from the Counter.Lib cannot be directly referenced or used because of the above mentioned issues. 

## Install pre-requisites

You'll need to install the following pre-requisites in order to build SAFE applications

* The [.NET Core SDK](https://www.microsoft.com/net/download)
* The [Yarn](https://yarnpkg.com/lang/en/docs/install/) package manager (you can also use `npm` but the usage of `yarn` is encouraged).
* [Node LTS](https://nodejs.org/en/download/) installed for the front end components.
* If you're running on OSX or Linux, you'll also need to install [Mono](https://www.mono-project.com/docs/getting-started/install/).

## Work with the application

Before you run the project **for the first time only** you should install its local tools with this command:

```bash
dotnet tool restore
```


To concurrently run the server and the client components in watch mode use the following command:

```bash
dotnet fake build -t run
```


## SAFE Stack Documentation

You will find more documentation about the used F# components at the following places:

* [Saturn](https://saturnframework.org/docs/)
* [Fable](https://fable.io/docs/)
* [Elmish](https://elmish.github.io/elmish/)
* [Fable.Remoting](https://zaid-ajaj.github.io/Fable.Remoting/)
* [Fulma](https://fulma.github.io/Fulma/)

If you want to know more about the full Azure Stack and all of it's components (including Azure) visit the official [SAFE documentation](https://safe-stack.github.io/docs/).

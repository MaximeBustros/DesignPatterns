# What is the Singleton Design Pattern ?
It's a creational design pattern that allows to create an object once and shared it with clients.

# What are some use cases for the Singleton Design Pattern
* Configuration manager: since your config is shared throughout the app.
* Logging service: in order to avoid having multiple loggers writing to the same file or console.
* Connection manager: To manage shared and expensive resources like DB connections
* Caching: since we can share the same instance of an in-memory stored cache

# How to identify when the Singleton Design Pattern is the right candiate for a class ?
To ask yourself these questions:
* Do we want to control access to a shared resource ?
* Does it make sense to have multiple have multiple instances of this object ?

# Why is the contructor private in a singleton ?
In order to protect creating a new instance of the Singleton object
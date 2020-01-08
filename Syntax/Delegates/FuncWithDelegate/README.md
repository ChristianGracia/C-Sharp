# Func C#

Func is built-in delegate type.
Func delegate type must return a value.
Func delegate type can have zero to 16 input parameters.
Func delegate does not allow ref and out parameters.
Func delegate type can be used with an anonymous method or lambda expression.


C# 3.0 includes built-in generic delegate types Func and Action, so that you don't need to define custom delegates as above.

Func is a generic delegate included in the System namespace. It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.

You can use this delegate to represent a method that can be passed as a parameter without explicitly declaring a custom delegate. The encapsulated method must correspond to the method signature that is defined by this delegate. This means that the encapsulated method must have one parameter that is passed to it by value, and that it must return a value.
# Cocus code review 

Cocus Challenge - Exercise 2 

  

The provided code, in exercise 2, reads as follows: 

``` 

if (message is MessageA) { 

    var messageA = message as MessageA; 

    messageA?.MyCustomMethodOnA(); 

} else if (message is MessageB) { 

    var messageB = message as MessageB; 

    messageB?.MyCustomMethodOnB(); 

    messageB?.SomeAdditionalMethodOnB(); 

} else if (message is MessageC) { 

    var messageC = message as MessageC; 

    messageC?.MyCustomMethodOnC(); 

} 

  

``` 

  

There are several problems with this code, and that's the reason why I consider it to be of a quite low quality. 

The first evident problem if the lack of encapsulation, and the code does not follow any of the SOLID rules, especially the Liskov substitution principle. Obviously, the classes that are being called are not available in the provided code, however we can assert that they're probably not related in any sort, so we can probably create some dependency between them through inheritance, and abstracting the generic code in the parent class, thus making the logic overridable. 

  

The current repository presents an improved version of the code. 

  

Thanks for the challenge. It was fun. 

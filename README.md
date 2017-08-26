# constructor
It’s of course a good idea to put a new object into is valid state as soon as possible before you start accessing it normally at the time of instantiation. This would mean that you would want to construct the values for those fields – that represent that state – somewhere on the line of code where the new keyword is used. fortunately, there is a special method for us to do this and this method is called a Constructor.
Car myNewCar = new Car ("oldschool", "Mercedez" , 1867, "White")
In this case we are populating our Constructor with the values from our Car class-level properties, or simply put this way that we passed in the values that belong to the Car class-level properties as an input parameter at instatiation. 
Obviously Constructor is created whenever we create a new Object , that means we have called on the default , empty constructor by using the empty parentheses.
3 differences between Normal Method and Constructor:
It has the  same name as the class it belongs to.
It has no return value.
After the new keyword, It most be called.

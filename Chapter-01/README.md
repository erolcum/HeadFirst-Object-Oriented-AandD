Codes are for a guitar shop. You need to find the guitar which has a requested specs. <br>You can write toString() method in enum in Java. But it is not possible to write in C#. Instead, you can use method extensions. Enums are used to prevent mistyping. You can see them in GuitarSpec.cs<br>
The heart of the project is a method, **public bool Matches(GuitarSpec otherSpec)** in GuitarSpec.cs. It returns bool and it checks if searched spec matches the spec of a guitar. Another method **public List<Guitar> Search(GuitarSpec searchSpec)** in Inventory.cs uses that Matches method. It returns a list of guitars.<br>
FindGuitarTester.cs :<br>
___

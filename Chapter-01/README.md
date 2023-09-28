Codes are for a guitar shop. You need to find the guitar which has a requested specs. <br>You can write toString() method in enum in Java. But it is not possible to write in C#. Instead, you can use method extensions. Enums are used to prevent mistyping. You can see them in GuitarSpec.cs<br>
The heart of the project is a method, **public bool Matches(GuitarSpec otherSpec)** in GuitarSpec class. It returns bool and it checks if searched spec matches the spec of a guitar. Another method **public List<Guitar> Search(GuitarSpec searchSpec)** in Inventory class uses that **Matches** method. It returns a list of guitars.<br>
**guitar.getSpec().Matches(searchSpec)** this line of code is in Inventory class. guitar.getSpec() returns a GuitarSpec. GuitarSpec class has the method **Matches**. So matching work is delegated to GuitarSpec class.

___
**FindGuitarTester.cs :**
1. new Inventory(), creates a **list**. You can see it in the constructor of Inventory class.
2. InitializeInventory(inventory), creates 11 GuitarSpecs (instances) and send them to the guitar **list** by using AddGuitar method of inventory. This method creates 11 Guitar instances. So, each Guitar instance has a serialnumber, price and a GuitarSpec instance.
3. GuitarSpec whatErinLikes =..., an instance of a GuitarSpec is created to search in inventory.
4. List<Guitar> matchingGuitars = inventory.Search(whatErinLikes), this spec is sent to Search method in inventory. matchingGuitars list is created in that method and filled with matching guitars
5. matchingGuitars list is printed on screen.

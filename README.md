# ShapeAreaCalculator

The calculator's menu is handled within the Main function and instantiates instances of Circle, Triangle, Rectangle, or NGon classes to handle shape-specific area calculations

## Design

* There is an `AbstractShape` base class which provides three members:
  * `_area`: double representing the shape's area
  * `double GetArea()`: Returns the above ^^ to two decimal places. Could have been an accessor property, but I was back in the C++ console dev mentality and forgot that properties existed for a minute
  * `void GetDimensions()`: A place for user input, making the input methods consistent between each shape
* The classes `Circle`, `Triangle`, `Rectangle`, and `NGon` all inherit from the `AbstractShape` base class to provide shape-specific input instructions and area calculations
* The main loop "design" has it in `Main` itself - I don't love that, but for such a simple program it didn't make much sense to extract it into it's own object or function. For other use-cases, I'd have provided a controller class with better program control/IO functionality etc

## Considerations

* I toyed with the idea of setting these up as API endpoints and displaying the data in a web front-end, but ultimately determined it wouldn't make much of a difference, practically
* The use of an interface was initially considered, however I soon remembered how truly different the area calculations are for each shape. Multiple overloads, one per shape, would have been required - and I can't see much benefit to that as it's unlikely the actual implementation of an area calculation will change!
* I debated whether inheritance was even relevant for this use case, but decided that it could be made use of for the 'peripheral' functions relating to area calculation - that is dimension input and the return of the area itself. Sharing the `_area` member was a nice bonus

## Issues

* Ideally I wouldn't implement user controls/input within the shape implementation classes themselves - for this particular (extremely simple) use case it makes sense to utilise the abstract base class to standardise shape dimension input. If this were part of a larger application, the user input would be abstracted out of the shape classes
* It has been a long time since I have written a C# console application (if ever?) and it took some time to recall how the entry points and console input/outputs worked - this is something I'm more familiar with in C++ or C. I might even be more familiar with it in Python 🤮
* I became sidetracked looking into the math surrounding regular N-Gon area calculations and the derivations. Had I not done that, I likely could have looked into a nicer UI or spent more time on this Readme

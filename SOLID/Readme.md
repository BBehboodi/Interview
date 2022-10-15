# SOLID

**SOLID** principles used to **make software design** more **understandable**, **flexible**, and **maintainable**.  
We are using it because developers start building applications with good designs using their knowledge and experience.  
But over time, applications might develop bugs.  
The application design must be altered for every change or new feature request.  
After some time we might need to put in a lot of effort, even for simple tasks and it might require full working knowledge of the entire system.  
But we can't blame change or new feature requests.  
They are part of software development.  
We can't stop them or refuse them either.  
By **following solid principles**, we can **control** the **volume** and **cost** of the **changes**.  

**SOLID** is an **acronym** for **five principles**:  

  - **S**: Single Responsibility  
    **Every class** should have **only one job** to do, and should be **related** to a **single purpose**.

  - **O**: Open/Closed  
    A **class** it should **open for extension** and **closed for modification**.  
    **Open for extension** means, we need to **design** our **class** in such a way that the **new functionality** can be **added only** when **new requirements** are **generated**.  
    **Closed for modification** means we have **already developed** a **class** and it has gone **through unit testing**. We **should** then **not alter** it until we **find bugs**.

  - **L**: Liskov Substitution  
    It ensures that a **derived class** does **not affect** the **behavior** of the **parent class**.  
    It means that we must **ensure** that **new derived classes** **extend** the **base classes** **without changing** their **behavior**.

  - **I**: Interface Segregation  
    According to **S** principle, each **class** should have **one purpose**.  
    **Classes should not** be forced to **implement interfaces** they **don't use**.  
    Instead of one flat interface, We should create **small interfaces** based on **groups of methods** that each one **serving one sub module**.  

  - **D**: Dependency Inversion  
    **High-level** classes **implement business** rules or logic in a system.  
    **Low-level** classes deal with more **detailed operations** like interacting with databases or passing messages to the operating system and etc.  
    **High-level** classes have **dependecies** to **Low-Level** classes and knows a lot about the other classes.  
    When **High-Level** classes **knows** about the **design** and **implementation** of **Low-Level** classes, it **raises** the **risk** that **changes to one class will break the other class**.  
    **Dependency Inversion** ensures that **High-Level** classes **depend** on the **abstraction of the Low-Level** classes, Instead of having a lot of information about them.
# Testing Pyramid
**Testing Pyramid** is a **framework** that can **facilitate** both **developers** and **QAs** to build **high-quality** **software**.  
It **minimizes** the **amount of time** required for **developers** to **determine** if an **update** they made **affects** **the code**.  
It **specifies** the **types of tests** that **should** be **included** in an **automated testing**.  
Moreover, It **defines** the **order** and **frequency** of types of tests.  
The whole **point** is to offer **immediate feedback** to **ensure** that **code changes** **do not disrupt** **existing features**.  

  - **Level 1, Unit Test**:  
    Unit Tests form the **base** of the **testing pyramid**.  
    They **test individual components** or **functionalities** to **validate** that it **works as expected** in **isolated conditions**.  
    They are **not depend** on **extenal resources** such as Databases, APIs, etc.  
    It is **important** to **run** a **number of scenarios** in **Unit Tests**, Such as happy path, error handling, etc.  

  - **Level 2, Integration Tests**:  
    They are tests that **validate** the **interaction of a piece of code** with **external components** such as Databases, APIs, etc.  
    They **should not** be **run** as **frequently** as **unit tests**.  
    They **test** how a **feature** **communicates** with **external dependencies**.  

  - **Level 3, End-to-End Tests**:  
    At the **top** of **the pyramid** are the end-to-end tests.  
    These **ensure** that the **entire application** is **functioning** as required.  
    **End-to-end** tests do **exactly** what the **name suggests**: Test that the **application** is **working** flawlessly **from start to finish**.  
    When running these tests, it is **important** to **imagine** the **user’s perspective** and how would an **actual user** **interact with the app**.  
    **End-to-end** tests are at the **top** of the **testing pyramid** because they usually **take the longest to run**.  
    
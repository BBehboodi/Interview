# Reference Type VS Value Type

In C# **Data types** are **categorized** based on how they **store** their value in the **memory**.

  - **Value Type**:  
    The variables of these data types directly contain values.  
    Consider integer variable ``int i = 100``.  
    The system stores 100 in the memory space allocated for the variable `i`.

  - **Reference Type**:  
    A reference type contains a pointer to another memory location that holds the data.  
    Consider the following string variable ``string s = "Hello World!!"``.  
    The system selects a random location in memory for the variable s.  
    The value of a variable `s` is in the memory address of the actual data value.  
    The reference type stores the address of the location where the actual value is stored instead of the value itself.

# Passing Reference Types VS Passing Value Types

  - **Passing Value Types**:  
    When you pass a value type variable from one method to another, the system creates a separate copy of a variable in another method.   
    If value got changed in the one method, it wouldn't affect the variable in another method.

  - **Passing Reference Types**:  
    When you pass a reference type variable from one method to another, it doesn't create a new copy. Instead, it passes the variable's address.  
    So, If we change the value of a variable in a method, it will also be reflected in the calling method.
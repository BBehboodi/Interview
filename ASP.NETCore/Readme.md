# ASP.NET Core

## Action Filter

An **action filter** is an **attribute** that you can **apply** to a **controller action** or an **entire controller** that **modifies** the way in which the action is executed.  

**The ASP.NET MVC framework includes several action filters**:  
  - **OutputCache**: This action filter **caches** the **output** of a **controller action** for a **specified amount of time**.  
  - **HandleError**: This action filter **handles errors** raised when a **controller action executes**.  
  - **Authorize**: This action filter **enables** you to **restrict access** to a **particular user** or **role**.  
You also can **create** your own **custom action filters**. For example, you might want to create a custom action filter in order to implement a custom authentication system.  

**The Different Types of Filters**:  
  - **Authorization filters**: Implements the **IAuthorizationFilter** attribute.
  - **Action filters**: Implements the **IActionFilter** attribute.
  - **Result filters**: Implements the **IResultFilter** attribute.
  - **Exception filters**: Implements the **IExceptionFilter** attribute.  
**Filters** are **executed** in the **order** listed **above**.  
The **base class** for **all action filters** is the **System.Web.Mvc.FilterAttribute** class. If you want to implement a particular type of filter, then you need to create a class that inherits from the base Filter class and implements one or more of the IAuthorizationFilter, IActionFilter, IResultFilter, or IExceptionFilter interfaces.

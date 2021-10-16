# Generic Response
Generic Response for .net projects


## Installing


```shell
  Install-Package Ceyhan.GenericResponse -Version 1.0.0
```

## Usage

```cs
  using GenericResponse;
```

Return success


```cs
  public static GenericResponse<User> FakeService(User user)
  {
     return new GenericResponse<User>(user);
  }
```

Return fail


```cs
  public static GenericResponse<User> FakeService(User user)
  {
     return new GenericResponse<User>("Something happend");
  }
```


Check methods response


```cs
  var userRegisterResponse = RegisterNewUser(user);


  if (userRegisterResponse.Success)
  {
     Console.WriteLine($"User {userRegisterResponse.GenericModel.Name} is successfully registered");
  }
  else
  {
     Console.WriteLine($"Log error - {userRegisterResponse.Message}");
  }

```




For interfaces;

```cs
 public interface IUserService
 {
     Task<GenericResponse<User>> Logout(string token);
 }
```

## TODO

* Add more examples
* Publish as a nuget pack



## Licensing

This project is licensed under MIT license. 


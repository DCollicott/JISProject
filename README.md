<html>
<body>
<h1>JISProject</h1>
<b>
Duane Collicott
<br />
November 29, 2017
</b>

<hr />

<p>
Greetings.
</p>

<p>
This caluclator assignment could have been written completely in the client using Javascript, but your instructions were to make use of C# and MVC as well, and therefore I put some of the processing in the client and some in the C# code. My guess was that you wanted to see both some UI and some back end work. I hope this will be acceoptable to you.
</p>

<p>
I used Visual Studio 2015. NuGet was used to load packages (NUnit, Bootstrap, etc). I hope they will simply load for you.
</p>

<p>
There are three projects in this solution:
</p>
<ul>
  <li>
    JISProject.Test - This is the unit test project, which uses NUnit and the NUnit Test Adapter.
  </li>
  <li>
    JISProject.App - This is the UI proejct, utilizing ASP.Net MVC5 with C#, Razor, and Bootstrap.
    <br />
    This contains a single view model called CalcModel. THis model contains two properties, one for receiving the equation
    from the view and one for returning acleaned-up and calculated result. 
  </li>
  <li>
    JISProject.Engine - This is the workhorse.
    <br />
    This employs the concept ot two types of Entry objects. Both are derived from the common EntryBase class, so that 
    they can be used interchangeably.
    <ul>
      <li>PrimitiveEntry, which represents a single numeric value.</li>
      <li>OperationEntry, which represents a two other entries (EntryA and EntryB) and an operator (+, -, *, /, etc).
      Since both EntryA and EntryB are EntryBase types, they can each be isntances of either PrimitiveEntry or OperatorEntry.
      Using this scheme of multiply-nested OperatorEntry instances, infinantely-complex equations are supported.</li>
      </ul>
  </li>
</ul>

I ran out of time where I would have implemented the parsing of the input equation form the UI and the calculating of the result.
</body>
</html>

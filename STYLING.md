# Styling

We should observe the following styling conventions to keep a clean, consistent look to our code and commit history.

## Code

### Naming Conventions
- Names should clearly denote what the var, class, etc. is responsible for
- Descriptive names should be favored over brevity

### Capitalization Conventions
| Type | Convention |
| :--- | --- |
| Variable | camelCase |
| Properties | PascalCase |
| Constant | SNAKE_CASE_ALL_CAPS |
| Function | PascalCase |
| Class | PascalCase |
| Struct | PascalCase |
| Namespace | PascalCase |

### Class Conventions
To allow for quick understanding of unfamiliar code, we should keep a consistent styling in all of our C# class files.

For an example file of current conventions, see the sample C# file at [ExampleClass.cs](./Assets/Scripts/Samples/ExampleClass.cs)

The following sections will reference the example class file. Each "section" of code should be separated by a single line of whitespace.

#### Imports
Imports should be located at the top of the file. Unused imports should be removed.

#### Namespaces
Each file's contents should be wrapped in a namespace that corresponds to its directory structure beginning at [project root]/Assets/Scripts/
For example, a script located at [project root]/Assets/Scripts/Diablo/PvE/Necromancer.cs would have its namespace as follows:
`namespace Diablo.PvE`

#### Classes
Class definitions should come next. If a class requires documentation, use a triple slash XML style comment before the class definition.

#### Public Properties
Properties come next and should be used in favor over public variables.

#### Private Variables
Private variables should come next.

#### Constructors
Constructors and factory methods should come next.

#### Public Functions
Public functions should come next.

#### Private Functions
Private functions should come next.

### Monobehaviour Conventions
Monobehaviours should follow all conventions that normal C# classes follow and some additional conventions as well.

For an example file of current Monobehaviour conventions, see the sample C# file at [ExampleMonobehaviour.cs](./Assets/Scripts/Samples/ExampleMonobehaviour.cs)

#### Serialized Fields
Serialized fields should come directly after the class definition but before public properties. They should always be private and should be initialized to `default` to get rid of "uninitialized" warnings in the Unity Editor.

#### Unity Functions
Unity Functions (Awake, Start, OnEnable, Update, etc.) should replace the Constructors section of normal C# classes. All of these functions should be made private.

## Git Commits
We should keep a consistent git commit style as well. The original style guide is from this website: [https://www.conventionalcommits.org/en/v0.0.0/](https://www.conventionalcommits.org/en/v1.0.0/). Not all conventions are used, as the style guide has a lot of depth to it. However, the basics of the style guide are outlined below.

Here is the basic layout of a commit message:

    commit-type: short description, all lowercase in present tense

    Longer description of what the commit contains.


So an actual commit message could look something like this:

    feat: add settings section to main menu

    Move other buttons up by 29px to make space for settings button.

Below is a list of the possible types in the "commit-type" section.

### Commit Types

- feat: Used when pushing a new feature
- fix: Used when pushing a bug fix
- ref: Used when pushing code refactoring
- build: Used when modifying the build (bumped version number, new build process, etc.)
- test: Used when pushing code dealing with testing
- docs: Used when pushing documentation (code comments, README's, etc.)

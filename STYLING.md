## Code Styling

We should observe the following styling conventions to keep a clean, consistent look to our code.

### Naming Conventions
- Names should clearly denote what the var, class, etc. is responsible for
- Descriptive names should be favored over brevity

### Capitalization Conventions
| Type | Convention |
|--|--|
| Variable | camelCase |
| Constant | SNAKE_CASE_ALL_CAPS |
| Function | PascalCase |
| Class | PascalCase |
| Struct | PascalCase |
| Namespace | PascalCase |

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

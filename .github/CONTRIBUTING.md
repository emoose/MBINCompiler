## Contributing to MBINCompiler

There are a number of ways that anyone can contribute to the development of MBINCompiler, but the main two ways are as follows:

#### Providing Updated versions of structs

Every time Hello Games pushes an update to the game we check to see if there are any structs that have changed. If there have been changes then an issue will be created which has the *Update Info* tag.

If you have some reverse engineering skills you can create a Pull Request which fixes some or all of the structs that were broken by the update.

If your pull request would result in every struct that was changed being fixed (or finishes off the list of structs requiring updating in a given issue), then you should add `closes #XYZ` (where `XYZ` is the number of the issue that should be closed) to the text of the PR.

#### Providing names for unknowns in globals

As of NMS 2.0, HG removed the names of variables in all globals exept for the camera globals. Because of this, we have gone back to having a number of variables which have their effect unknown. This is a great place to start off contributing to MBINCompiler as it doesn't require any reverse engineering knowledge and can be done by simply using cheat engine to try and determine the values.

A number of globals also have some comments in the source code which indicate some suggestions for what the variables *may* do. In this case testing is required to confirm or deny whether the variable is in fact related to what the comment suggests.

### General protocol for opening a Pull Request

 - If you are working on a PR which may end up having a few commits, you can prepend the name of your PR with `[WIP]` to indicate that the PR is not yet complete.
 - Once you are happy with your PR, the title must be prepended with `[MRG]` to indicate that the PR is ready to go and the review process can take place.
 - Currently there is no testing done on the MBINCompile code base on a CI service, however this will hopefully come in the future and when it does, no PR will be able to be merged unless it passes any CI tests.

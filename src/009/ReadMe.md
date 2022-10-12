# Decision Structures

**If-Else** and **Switch-Case** are the standard decision statements for providing *alternate paths of logic* during our program's execution. These are also part of the group of statements known as ***flow control*** statements.

In a flowchart, the If-Else would look like this:

```mermaid
flowchart TD
    Enter[Some code before]
    First{First If}
    A[Step A]
    B[Step B]
    FirstClose(( ))
    Exit[Some code after]

    Enter-->First
    First== false ==>B==>FirstClose
    First== true ==>A==>FirstClose
    FirstClose-->Exit
```

If-Else statements only have two possible paths of logic - the `true` side and the `false` side. The [Case structure](#case-structure) can have more than two alternate paths of logic. At the end of both structures, the paths of logic converge to resume with the rest of the program's execution.

- **Review the grammar for**
  - [ ] [If-Else](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#if-else)
  - [ ] [Switch-Case](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#switch-case)


----

## Paths of Logic and Unassigned Variables

If you try to use a variable whose value is assigned only through *some* but not *all* possible paths of logic, the compiler will flag an "Unassigned variable" error, as shown in this code sample.

![Unassigned variable](./Images/Unassigned-Variable.png)

For each of the following flowchart examples, identify how many possible execution paths there are.

----

## Stacked Structures

```mermaid
flowchart TD
    First{First If}
    Second{Second If}
    A[Step A]
    B[Step B]
    C[Step C]
    D[Step D]
    E[Step E]
    FirstClose(( ))
    SecondClose(( ))

    First-- false -->FirstClose
    First-- true -->A-->B-->FirstClose

    FirstClose-->Second

    Second-- false -->E-->SecondClose
    Second-- true -->C-->D-->SecondClose
```

----

## Nested Structures

```mermaid
flowchart TD
    First{First If}
    Second{Second If}
    A[Step A]
    B[Step B]
    C[Step C]
    D[Step D]
    E[Step E]
    FirstClose(( ))
    SecondClose(( ))

    First-- false -->Second
    First-- true -->A-->B-->FirstClose
    Second-- false -->E-->SecondClose-->FirstClose
    Second-- true -->C-->D-->SecondClose
```

----

## Case Structure

```mermaid
flowchart TD
    Switch{Value =}
    A[Step A]
    B[Step B]
    C[Step C]
    D[Step D]
    E[Step E]
    Default[Default Step]
    Close(( ))
    
    Switch-- A -->A-->Close
    Switch-- B -->B-->Close
    Switch-- C -->C-->Close
    Switch-- D -->D-->Close
    Switch-- E -->E-->Close
    Switch-- otherwise -->Default-->Close
```

----

## Mixed Examples

> TODO: Draw on whiteboard

```mermaid
flowchart TD

```

----

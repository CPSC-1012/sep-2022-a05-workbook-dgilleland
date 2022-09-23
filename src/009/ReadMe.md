# Decision Structures

- Review the grammar for
  - [If-Else](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#if-else)
  - [Switch-Case](https://programming-0101.github.io/TheBook/Teach/chapter1-7.html#switch-case)


For each of the flowchart examples, identify how many possible execution paths there are.

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

<div align="center">

  <h1>Thaumaturge: Design Document</h1>

</div>



1. `CardName` from AtomicCards.json -> CardName.json

```text
{CardName1},
{CardName2},
{CardName3}
```

2. `Set` for each `CardName` in AtomicCards.json -> CardSets.json

```text
{CardName1},
	{Set1, Set2, Set3...}
{CardName2},
	{Set1, Set2, Set3...}
{CardName3}
	{Set1, Set2, Set3...}
```

3. `Color` for each `CardName` in AtomicCards.json -> CardColors.json
3. 
```text
{CardName1},
	{Color1, Color2, Color3...}
{CardName2},
	{Color1, Color2, Color3...}
{CardName3}
	{Color1, Color2, Color3...}
```


XX. Build `thaumaturge.database`

```text
{CardName1},
	{Set1, Set2, Set3...},
	{Color1, Color2, Color3...},
{CardName2},
	{Set1, Set2, Set3...},
	{Color1, Color2, Color3...},
{CardName3},
	{Set1, Set2, Set3...}
	{Color1, Color2, Color3...}
```



***

<br>

<sub>Last updated: 260712</sub>

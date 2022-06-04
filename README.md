# Diff
![WTFPL](http://www.wtfpl.net/wp-content/uploads/2012/12/wtfpl-badge-1.png)  
<img src="https://www.nuget.org/Content/gallery/img/logo-header.svg?sanitize=true" height="30px">  
Get textual diffs.

### Download
Diff is available as [Nuget Package](https://www.nuget.org/packages/Diff/) now.

### Functions
```c#
static public List<DiffRes> Diff(List<string> orig, List<string> rev);
static public List<DiffRes> Diff(string orig, string rev);
static public List<GroupedDiffRes> GetGroupedResult(List<DiffRes> diffResList);
static public List<SplitedDiffRes> GetSplitedResult(List<DiffRes> diffResList)
static public List<SplitedDiffRes> GetSplitedResult(List<GroupedDiffRes> rangeList)
```
  
### Class
**DiffRes**
```c#
DiffType type;
int index;
```

**GroupedDiffRes**
```c#
int rangeStart;
int rangeEnd;
DiffType type;
```

**SplitedDiffRes**
```c#
int origIndex;
int revIndex;
SplitedDiffType type;
```
  
### Enum
**DiffType**
- Add
- Delete
- None

**SplitedDiffType**
- Add
- Delete
- None
- Modify

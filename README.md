# Diff
![WTFPL](http://www.wtfpl.net/wp-content/uploads/2012/12/wtfpl-badge-1.png)  
<img src="https://www.nuget.org/Content/gallery/img/logo-header.svg?sanitize=true" height="30px">  
Get textual diffs.

### Download
Diff is available as [Nuget Package](https://www.nuget.org/packages/Diff/) now.

### Functions
static public List\<DiffRes\> **Diff**(List\<string\> orig, List\<string\> rev)  
static public List\<DiffRes\> **Diff**(string orig, string rev)
  
### Class
**DiffRes**
- DiffType type
- int index
  
### Enum
**DiffType**
- Add
- Delete
- None

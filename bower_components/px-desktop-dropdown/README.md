px-dropdown
============

## Using px-dropdown

`px-dropdown` is an input that allows the user to choose from a specified list of options.

```html
<px-dropdown placeholder="Select fruit..." value="{{selectedValue}}">
	<px-item value="apple">Apple</px-item>
	<px-item value="raspberry">Blue Raspberry</px-item>
	<px-item value="cherry">Cherry</px-item>
</px-dropdown>
```

### Selection from a collection

The list of px-items can be generated dynamically from an array or object

```javascript
items = ['Apple', 'Blue Raspberry', 'Cherry'];
```

or 

```javascript
items = {
	apple: 'Apple',
	rasberry: 'Blue Raspberry',
	cherry: 'Cherry'
};
```
could be used with the following html:

```html
<px-dropdown value="{{selectedValue}}" items="{{items}}"></px-dropdown>
```

## label-key and value-key

Selectable objects can have a custom label and/or custom value with a label-key and/or value-key

For example, given this list of items:

```javascript
authors = [
   {name: 'Alan', id: 3},
   {name: 'Eric', id: 4},
   {name: 'Joe',  id: 5}
];
```

the following html would assign the id of each author to the selectedId, while labeling each selectable item with the name.

```html
<px-dropdown value="{{selectedId}}" items="{{authors}}" label-key="name" value-key="id"></px-dropdown>
```

## equals

Items supports an equals function that will select based on its value

For example, given this list of items:

```javascript
authors = {
   Alan : {id: 3},
   Eric : {id: 4},
   Joe : {id: 5},
};

selectedAuthor = {id: 3};

authorEquals = function(a1, a2) {
	return a1.id === a2.id;
}
```

the following html would display "Alan" as selected

```html
<px-dropdown value="{{selectedAuthor}}" items="{{authors}}" equals="{{authorEquals}}"></px-dropdown>
```

## compare

Items can additionally be sorted based on their label and values, using `Array.sort`. The values given to the compare function are objects with keys `label` and `value`.

For example, given this list of items:

```javascript
authors = {
   Eric : {id: 4},
   Joe : {id: 5},
   Alan : {id: 3},
};

//Sort by Name
authorCompare = function(a1, a2) {
	return a1.label.localeCompare(a2.label);
}
```

the following html would display the options "Alan", "Eric" and "Joe", in that order.

```html
<px-dropdown value="{{selectedAuthor}}" items="{{authors}}" compare="{{authorCompare}}"></px-dropdown>
```


### Insertion of other elements

Other elements contained are added below the generated by items list.

```html
<px-dropdown value="{{selectedValue}}" items="{{items}}">
	<px-item value="none">None of the above</px-item>
</px-dropdown>
```

Other elements can also be added. Including the `first` attribute will add them to the beginning of the list.
```html
<px-dropdown value="{{selectedValue}}" items="{{items}}">
	<px-button first>Add new fruit</px-button>
</px-dropdown>
```

### Other types of dropdowns

A `textboxstyle` dropdown allows the user to enter their own values:

```html
<px-dropdown value="{{selectedValue}}" items="{{items}}" textboxstyle>
</px-dropdown>
```

An `action` dropdown prevents selection

```html
<px-dropdown value="{{selectedValue}}" items="{{items}}" action>
	<px-button>Add fruit</px-button>
	<px-button>Remove fruit</px-button>
</px-dropdown>
```
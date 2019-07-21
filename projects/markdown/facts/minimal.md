# 3-Minute Markdown Overview

Markdown consists of two types of lexical constructs: inlines and blocks.  

## Inlines

Inlines are words which can be formatted in **bold**, *italic*, or `monospace`.  They can also refer to hyperlinks such as to the [Typedescriptor web site](https://typedescriptor.net).   Some Markdown implementations automatically mark hyperlinks (like this one to https://typedescriptor.net) even if they don't use markup.  Many Markdown implementations let you treat images as inlines by using hyperlinks prefixed by an exclamation point: ![Image of Yaktocat](https://octodex.github.com/images/yaktocat.png)

## Blocks

As for blocks, there are several kinds. One such block is the paragraph (such as this block) which is separated from other blocks using a blank line.  There are also:

* bulleted lists (such as the several items in this list),
* numbered lists, for example, this next block:

  1. One

  2. Two

     (a) Sub-item

     (b) Another sub-item

* headings (as in the text ``## Blocks`` above), 
* quotes:

  > Quotes are indicated with the `>` symbol, and often include a citation
  > such as `Typedescriptor Research` denoted below. 
  > 
  > -- Typedescriptor Research

* code, like this next block:

      Longer blocks of literal text, such as computer code are indented with four additional spaces like this block.

Lists can nest to multiple levels.  Just like lists, headings can also nest by using more `#` symbols, just as this document does to create two sub-headings.

Any arbitrary HTML can be used where markdown doesn't have a syntax.  Inlines can be <u>underlined</u> and <s>struck-through</s> using HTML.  Tables are defined using the HTML tags (`<table>`, `<tr`>, `<td>`, etc.)

## Conclusion

That's all for the basics.  There are several other details such as alternate characters in inlines and headings, significant whitespace, and variations between different "flavors" of Markdown, but they require more explaining.  

# Char-diferentiator-generator
Given char sequences it generates a if sequence that differentiates those chars

## usage
either copy a section from the displayed char list or type the start and the end of the section
you can also type the representant char and it's range to assing the return

## example

AZ

abcdefghijklmnopqrstuvwxyz

09

\# !"#$%&'()*+,-./

\# :@

\# [\]^_`

\# {|}~

gives you
```javascript
     if(m < 'A')
     if(m < '0') return '#';
else if(m < ':') return '0';
else             return '#';
else if(m < 'a')
     if(m < '[') return 'A';
else             return '#';
else if(m < '{') return 'a';
else             return '#';
```
## commands

cls : clear 

switch : generate switch case for the output

This project is a stripped down version of a translations framework that I developed.  Our web application had hundreds of pages, and on each one of the pages we had several headers, sub-headers, labels, form instructions, and confirmation messages for each web page.  This quickly added up to thousands of phrases.  

Linearly looking up a phrase and getting its translated phrase was slowing down our page for non-english users.  

We needed to get creative.  We first dividied our pages by modules.  If a phrase had to do with insurance, we could limit only to phrases that were dealing with insurance by passing in the product code.  
While we gained some efficiency with this solution, we knew that we could optimize even more.  

Our next step was to go to a binary search instead of a linear search.  We made our class inherit the IComparer interface, so we could sort it and keep the sorted collection in memory.  We used the singleton design pattern to keep the collection from getting re-poppulated.  

We also optimized string look ups, by looking up the length of the string before comparing strings.  

All of these efficences allowed for us to go live with our translations framework which supports 10 languages currently.  

The project that I have uploaded will work with the below request
{
  "productCode": "in",
  "languageCode": "gm",
  "phraseToTranslate": "Your insurance documents have been submitted"
}

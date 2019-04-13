

class example
{

		// Move comments from behind to above
		
		// s/\(.*\)\(\/\/.*\)/\t\t\2\r\1\r

		public double SeriousProperty { set; get; }	// the meaning of this property is super secret

		// --------------
 
		// normal comment to summary
		
		// s/\/\/\s*\(.*\)/\/\/\/\t<summary>\r\t\t\/\/\/\t\t\1\r\t\t\/\/\/\t<\/summary>
		
		
		// Nice short abstract
		public void ThisMethodNeedsDocumentation()
		{

		}
		
        // --------------

		// Add visibility to method

		// s/^\(\s*\)\(\w\)/\1public \2
		
		// don't add visibility to this comment
		int MissingVisibilityMethod() => return 0;

		
		// --------------
		
		// From statement to expression body
		
		// s/\n\s*{\s*\n\s*return\s*\(.*\)\n\s*}/ => \1/g
		public int LifeUniverseAndEverything()
		{
			return 42;
		}
		
		public int LifeUniverseAndEverythingAndMore()
		{
			return 43;
		}


		// --------------

		// return code to xml-list item
		
		// s/^\D*\(\d\+\(,\s*\d\)*\)\s*\(.*\)$/\t\t\/\/\/\t<item>\r\t\t\/\/\/\t\t<term>\1<\/term>\r\t\t\/\/\/\t\t<description>\3<\/description>\r\t\t\/\/\/\t<\/item>
		
		//	*		1, 2, 3        multiple return codes
		//	*		4              4 ever
		//	*		5              high 5
		//	*		6              sinister 6
		public int MethodWithReturnCodes()
		{
			return 0;
		}
}

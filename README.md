# multiple-imager-js

- Quraşdırılma qaydası və əlaqəli faylların qoşulmasl
    - Bootstrap css inteqrasiyası(https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css)
    - Font Awesome inteqrasiya edilməsi(https://kit.fontawesome.com/1154e1d6ee.js)
    - Qoşmanın öz style faylının inteqrasiyası(libs/multiple-imager-js/css/imager.css)

<p>
    Təq kompleksinin yerləşdirilməsi
</p>

<pre>
    &lt;div style="width: 600px;" class="imager-container" id="viewer1" name="files"&gt;
        &lt;label thumb-url='https://picsum.photos/300?v=1' image-id="1" checked="true"&gt;&lt;/label&gt;
        &lt;label thumb-url='https://picsum.photos/300?v=2' image-id="2"&gt;&lt;/label&gt;
        &lt;label thumb-url='https://picsum.photos/300?v=3' image-id="3"&gt;&lt;/label&gt;
        &lt;label thumb-url='https://picsum.photos/300?v=4' image-id="4"&gt;&lt;/label&gt;
        &lt;label thumb-url='https://picsum.photos/300?v=5' image-id="5"&gt;&lt;/label&gt;
    &lt;/div&gt;
</pre>

-   Jquery inteqrasiyası(https://cdnjs.cloudflare.com/ajax/libs/jquery/3.5.1/jquery.min.js)
-   Qoşmanın öz script faylının inteqrasiyası(libs/multiple-imager-js/js/imager.js)

<p>
    Builder methodun çağırılması
</p>

<pre>
    &lt;script&gt;
        $('#viewer1').imgadd({
            tnWidth: '120px',
            tnHeight: '120px',
            fontSize: '55px',
            plusInnerHtml: '',
            plusBtnClass: undefined
        });
    &lt;/script&gt;
</pre>



<pre>
ConnectionStringExamples:

SqlAuthentication
   data source=your_instance_name;
   initial catalog=your_database_name;
   user id=your_login;
   password=your_password;   
   MultipleActiveResultSets=True


Windows Authentication
   data source=your_instance_name;
   initial catalog=your_database_name;
   persist security info=True; 
   Integrated Security=SSPI;
</pre>


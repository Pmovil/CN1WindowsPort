namespace com.codename1.impl
{
    class Tchange : java.lang.Object, java.lang.Runnable
    {
        public com.codename1.ui.TextArea currentlyEditing;
        public java.lang.String text;
        public virtual void run()
        {
            if (currentlyEditing != null)
            {
                currentlyEditing.setText(text);
            }
        }
    }
}

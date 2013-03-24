using System;


public abstract class EncryptableDocument : BinaryDocument,IEncryptable
{
    public bool IsEncrypted {get; private set;}

    public void Encrypt()
    {
        IsEncrypted = true;
    }

    public void Decrypt()
    {
        IsEncrypted = false;
    }

    public override string ToString()
    {
        if (this.IsEncrypted)
        {
            return this.GetType().Name + "[encrypted]";
        }
        else
        {
            return base.ToString();
        }
    }
}
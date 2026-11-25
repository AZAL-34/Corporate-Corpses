using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private enum State
    {
        IDLE,
        WALK,
        HURT,
        STUN
    }

    private enum Direction
    {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public int attackDamage;
    public int attackReach;
    public int maxHealth;
    public int moveSpeed;
    public Sprite IdleUp;
    public Sprite IdleDown;
    public Sprite IdleLeft;
    public Sprite IdleRight;
    public Sprite WalkUp;
    public Sprite WalkDown;
    public Sprite WalkLeft;
    public Sprite WalkRight;
    public Sprite HurtUp;
    public Sprite HurtDown;
    public Sprite HurtLeft;
    public Sprite HurtRight;
    public Sprite StunUp;
    public Sprite StunDown;
    public Sprite StunLeft;
    public Sprite StunRight;

    private int currentHealth;
    private SpriteRenderer spriteRend;
    private State state;
    private Vector2 direction;
    private Direction directionEnum;

    void GetInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (state != State.HURT && state != State.STUN)
            {
                state = State.WALK;
                direction += Vector2.up;
                directionEnum = Direction.UP;
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (state != State.HURT && state != State.STUN)
            {
                state = State.WALK;
                direction += Vector2.left;
                directionEnum = Direction.LEFT;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (state != State.HURT && state != State.STUN)
            {
                state = State.WALK;
                direction += Vector2.down;
                directionEnum = Direction.DOWN;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (state != State.HURT && state != State.STUN)
            {
                state = State.WALK;
                direction += Vector2.right;
                directionEnum = Direction.RIGHT;
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (state != State.HURT && state != State.STUN)
            {
                direction -= Vector2.up;
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (state != State.HURT && state != State.STUN)
            {
                direction -= Vector2.left;
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (state != State.HURT && state != State.STUN)
            {
                direction -= Vector2.down;
            }
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (state != State.HURT && state != State.STUN)
            {
                direction -= Vector2.right;
            }
        }
        if (direction == Vector2.zero)
        {
            state = State.IDLE;
        }
    }

    void UpdateSprite()
    {
        if (state == State.IDLE)
        {
            if (directionEnum == Direction.UP)
            {
                spriteRend.sprite = IdleUp;
            }
            else if (directionEnum == Direction.DOWN)
            {
                spriteRend.sprite = IdleDown;
            }
            else if (directionEnum == Direction.LEFT)
            {
                spriteRend.sprite = IdleLeft;
                spriteRend.flipX = true;
            }
            else if (directionEnum == Direction.RIGHT)
            {
                spriteRend.sprite = IdleRight;
                spriteRend.flipX = false;
            }
        }
        else if (state == State.WALK)
        {
            if (directionEnum == Direction.UP)
            {
                spriteRend.sprite = WalkUp;
            }
            else if (directionEnum == Direction.DOWN)
            {
                spriteRend.sprite = WalkDown;
            }
            else if (directionEnum == Direction.LEFT)
            {
                spriteRend.sprite = WalkLeft;
                spriteRend.flipX = true;
            }
            else if (directionEnum == Direction.RIGHT)
            {
                spriteRend.sprite = WalkRight;
                spriteRend.flipX = false;
            }
        }
        else if (state == State.HURT)
        {
            if (directionEnum == Direction.UP)
            {
                spriteRend.sprite = HurtUp;
            }
            else if (directionEnum == Direction.DOWN)
            {
                spriteRend.sprite = HurtDown;
            }
            else if (directionEnum == Direction.LEFT)
            {
                spriteRend.sprite = HurtLeft;
                spriteRend.flipX = true;
            }
            else if (directionEnum == Direction.RIGHT)
            {
                spriteRend.sprite = HurtRight;
                spriteRend.flipX = false;
            }
        }
        else if (state == State.STUN)
        {
            if (directionEnum == Direction.UP)
            {
                spriteRend.sprite = StunUp;
            }
            else if (directionEnum == Direction.DOWN)
            {
                spriteRend.sprite = StunDown;
            }
            else if (directionEnum == Direction.LEFT)
            {
                spriteRend.sprite = StunLeft;
                spriteRend.flipX = true;
            }
            else if (directionEnum == Direction.RIGHT)
            {
                spriteRend.sprite = StunRight;
                spriteRend.flipX = false;
            }
        }
    }

    void Move()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        state = State.IDLE;
        direction = Vector2.zero;
        directionEnum = Direction.DOWN;
    }

    void Update()
    {
        GetInput();
        UpdateSprite();
        Move();
    }
}
